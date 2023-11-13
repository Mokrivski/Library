using LibraryMPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var admins = API.GET<List<Admin>>("admins");
            var students = API.GET<List<Student>>("students");

            if (admins.Where(a => a.Login == loginBox.Text.Trim() && a.Password == passwordBox.Text.Trim()).Count() != 0)
            {
                FormAdmin form = new FormAdmin();
                form.Owner = this;
                form.Show();
                Hide();
                loginBox.Text = "";
                passwordBox.Text = "";
            }
            else if (students.Where(a => a.Login == loginBox.Text.Trim() && a.Password == passwordBox.Text.Trim()).Count() != 0)
            {
                FormStudent form = new FormStudent(students.Where(a => a.Login == loginBox.Text.Trim() && a.Password == passwordBox.Text.Trim()).FirstOrDefault().ID_Student);
                form.Owner = this;
                form.Show();
                Hide();
                loginBox.Text = "";
                passwordBox.Text = "";
            }
            else MessageBox.Show("Неправильный логин или пароль");
        }

        private void registrationLabel_Click(object sender, EventArgs e)
        {
            FormRegistration form = new FormRegistration();
            form.ShowDialog();
        }
    }
}
