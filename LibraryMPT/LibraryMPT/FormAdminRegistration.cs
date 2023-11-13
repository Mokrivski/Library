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
    public partial class FormAdminRegistration : Form
    {
        public FormAdminRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text) || string.IsNullOrWhiteSpace(repasswordBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (passwordBox.Text.Trim() != repasswordBox.Text.Trim())
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            var admins = API.GET<List<Admin>>("admins");
            var students = API.GET<List<Student>>("students");
            if (admins.Where(a => a.Login == loginBox.Text).Count() != 0 || students.Where(a => a.Login == loginBox.Text).Count() != 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }

            var newAdmin = new Admin(loginBox.Text.Trim(), passwordBox.Text.Trim());
            API.POST("admins", newAdmin);
            Close();
        }
    }
}
