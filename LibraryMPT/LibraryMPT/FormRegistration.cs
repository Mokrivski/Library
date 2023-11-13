using LibraryMPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryMPT
{
    public partial class FormRegistration : Form
    {
        private bool IsEdit, IsAdmin;
        private int IdStudent;
        public FormRegistration()
        {
            InitializeComponent();
            IsEdit = false;
            IsAdmin = false;
        }

        public FormRegistration(bool isEdit, int idStudent = 0)
        {
            InitializeComponent();
            IsAdmin = true;
            IsEdit = isEdit;
            IdStudent = idStudent;
            if (isEdit)
            {
                var student = API.GET<Student>($"students/{idStudent}");
                Text = "Изменение читателя";
                surnameBox.Text = student.Surname;
                nameBox.Text = student.Name;
                middlenameBox.Text = student.Middlename;
                birthdateBox.Value = student.Birthdate;
                phoneNumberBox.Text = student.PhoneNumber;
                loginBox.Text = student.Login;
                passwordBox.Text = student.Password;
                repasswordBox.Text = student.Password;
                button2.Text = "Изменить";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text) || string.IsNullOrWhiteSpace(repasswordBox.Text) || string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(surnameBox.Text) || !phoneNumberBox.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (birthdateBox.Value.AddYears(14) > DateTime.Today)
            {
                MessageBox.Show("Неверный формат даты рождения");
                return;
            }

            if (passwordBox.Text.Trim() != repasswordBox.Text.Trim())
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            var admins = API.GET<List<Admin>>("admins");
            var students = API.GET<List<Student>>("students");
            if ((admins.Where(a => a.Login == loginBox.Text).Count() != 0 || students.Where(a => a.Login == loginBox.Text).Count() != 0) && !IsEdit)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }

            Student newStudent = new Student(surnameBox.Text.Trim(), nameBox.Text.Trim(), middlenameBox.Text.Trim(), phoneNumberBox.Text, loginBox.Text.Trim(), passwordBox.Text.Trim(), birthdateBox.Value);
            if (!IsEdit) MessageBox.Show($"Номер вашего читательского билета: {API.POST("students", newStudent).ID_Student}", "Успешная регистрация");
            else
            {
                newStudent.ID_Student = IdStudent;
                API.PUT("students", newStudent, newStudent.ID_Student);
            }
            if (IsAdmin) (Owner as FormAdminReaders).RefreshGrid();
            Close();
        }
    }
}
