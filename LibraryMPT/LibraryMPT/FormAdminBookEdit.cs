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
    public partial class FormAdminBookEdit : Form
    {
        private List<Author> authorsList;
        private bool IsEdit;
        private Book EditBook;
        public FormAdminBookEdit()
        {
            InitializeComponent();
            IsEdit = false;
        }

        public FormAdminBookEdit(int idBook)
        {
            InitializeComponent();
            IsEdit = true;
            EditBook = API.GET<Book>($"books/{idBook}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAdminBookEdit_Load(object sender, EventArgs e)
        {
            authorsList = new List<Author>();
            RefreshAuthorCombo();
            RefreshPublishingCombo();
            if (IsEdit)
            {
                Text = "Изменить книгу";
                editButton.Text = "Изменить";
                nameBox.Text = EditBook.Name;
                publishingsBox.SelectedValue = EditBook.ID_PublishingHouse;
                yearBox.Text = EditBook.Year;
                countBox.Value = EditBook.Count;
                var authorBooks = API.GET<List<AuthorBook>>("authorBooks");
                foreach (AuthorBook authorBook in authorBooks)
                {
                    if (authorBook.ID_Book == EditBook.ID_Book)
                    {
                        authorsList.Add(API.GET<Author>($"authors/{authorBook.ID_Author}"));
                        API.DELETE("authorBooks", authorBook, authorBook.ID_AuthorBook);
                    }
                }
            }
            RefreshAuthorGrid();
        }

        public void RefreshPublishingCombo()
        {
            var publishings = API.GET<List<PublishingHouse>>("publishingHouses");
            publishingsBox.DataSource = publishings;
            publishingsBox.DisplayMember = "Name";
            publishingsBox.ValueMember = "ID_PublishingHouse";
        }

        public void RefreshAuthorCombo()
        {
            var authors = API.GET<List<Author>>("authors");
            List<AuthorCombo> authorsCombo = new List<AuthorCombo>();
            foreach (Author author in authors)
            {
                authorsCombo.Add(new AuthorCombo(author.ID_Author, author.GetInitials()));
            }
            authorBox.DataSource = authorsCombo;
            authorBox.DisplayMember = "Name";
            authorBox.ValueMember = "Id";
        }

        private void RefreshAuthorGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Фамилия", typeof(string));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Отчество", typeof(string));
            foreach (Author author in authorsList)
            {
                table.Rows.Add(author.ID_Author, author.Surname, author.Name, author.Middlename);
            }
            authorsGrid.DataSource = table;
            authorsGrid.Columns[0].Visible = false;
        }

        private class AuthorCombo
        {
            public AuthorCombo(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminPublishings form = new FormAdminPublishings();
            form.Owner = this;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminAuthors form = new FormAdminAuthors();
            form.Owner = this;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (authorBox.SelectedItem != null)
            {
                foreach (Author author in authorsList)
                {
                    if (author.ID_Author == int.Parse(authorBox.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Такой автор уже есть в списке");
                        return;
                    }
                }

                authorsList.Add(API.GET<Author>($"authors/{authorBox.SelectedValue}"));
                RefreshAuthorGrid();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (authorsGrid.SelectedRows.Count != 0)
            {
                authorsList.Remove(authorsList.Where(a => a.ID_Author == int.Parse(authorsGrid.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault());
                RefreshAuthorGrid();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || publishingsBox.SelectedItem == null || !yearBox.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (authorsList.Count == 0)
            {
                MessageBox.Show("Необходимо добавить хотя-бы одного автора");
                return;
            }

            var newBook = new Book(nameBox.Text.Trim(), yearBox.Text, int.Parse(countBox.Value.ToString()), int.Parse(publishingsBox.SelectedValue.ToString()));
            if (IsEdit)
            {
                newBook.ID_Book = EditBook.ID_Book;
                API.PUT("books", newBook, newBook.ID_Book);
            }
            else newBook = API.POST("books", newBook);
            foreach (Author author in authorsList)
            {
                API.POST("authorBooks", new AuthorBook(newBook.ID_Book, author.ID_Author));
            }
            (Owner as FormAdminBooks).RefreshGrid();
            Close();
        }
    }
}
