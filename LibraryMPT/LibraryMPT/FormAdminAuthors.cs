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
    public partial class FormAdminAuthors : Form
    {
        public FormAdminAuthors()
        {
            InitializeComponent();
        }

        private void FormAdminAuthors_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var authors = API.GET<List<Author>>("authors");
            authorsGrid.DataSource = authors;
            authorsGrid.Columns[0].Visible = false;
            (Owner as FormAdminBookEdit).RefreshAuthorCombo();
        }

        private void authorsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (authorsGrid.SelectedRows.Count != 0)
            {
                surnameBox.Text = authorsGrid.SelectedRows[0].Cells[1].Value.ToString();
                nameBox.Text = authorsGrid.SelectedRows[0].Cells[2].Value.ToString();
                middlenameBox.Text = authorsGrid.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (authorsGrid.SelectedRows.Count != 0)
            {
                var authorToDelete = API.GET<Author>($"authors/{authorsGrid.SelectedRows[0].Cells[0].Value}");
                API.DELETE("authors", authorToDelete, authorToDelete.ID_Author);
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(surnameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text))
            {
                Author author = new Author(surnameBox.Text.Trim(), nameBox.Text.Trim(), middlenameBox.Text.Trim());
                API.POST("authors", author);
                RefreshGrid();
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (authorsGrid.SelectedRows.Count != 0)
            {
                if (!string.IsNullOrWhiteSpace(surnameBox.Text) && !string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    Author author = new Author(surnameBox.Text.Trim(), nameBox.Text.Trim(), middlenameBox.Text.Trim());
                    author.ID_Author = int.Parse(authorsGrid.SelectedRows[0].Cells[0].Value.ToString());
                    API.PUT("authors", author, author.ID_Author);
                    RefreshGrid();
                }
                else MessageBox.Show("Заполните все поля");
            }
        }
    }
}
