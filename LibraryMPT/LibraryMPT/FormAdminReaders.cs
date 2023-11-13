using LibraryMPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMPT
{
    public partial class FormAdminReaders : Form
    {
        public FormAdminReaders()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (readersGrid.SelectedRows.Count != 0)
            {
                var studentToDelete = API.GET<Student>($"students/{readersGrid.SelectedRows[0].Cells[0].Value}");
                API.DELETE("students", studentToDelete, studentToDelete.ID_Student);
                RefreshGrid();
            }
        }

        public void RefreshGrid()
        {
            var students = API.GET<List<Student>>("students");
            readersGrid.Rows.Clear();
            foreach (Student student in students) readersGrid.Rows.Add(student.ID_Student, student.GetFIO(), student.PhoneNumber, student.Birthdate.ToString("dd.MM.yyyy"), student.Login, student.Password);
        }

        private void FormAdminReaders_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistration form = new FormRegistration(false);
            form.Owner = this;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistration form = new FormRegistration(true, int.Parse(readersGrid.SelectedRows[0].Cells[0].Value.ToString()));
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
