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
    public partial class FormAdmin : Form
    {
        public bool logout = false;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            Form1 form = Owner as Form1;
            form.Show();
            Close();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout)
            {
                Application.Exit();
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            borrowedBooksGrid.Rows.Clear();

            var books = API.GET<List<Book>>("books");
            var publishings = API.GET<List<PublishingHouse>>("publishingHouses");
            var authors = API.GET<List<Author>>("authors");
            var authorBooks = API.GET<List<AuthorBook>>("authorBooks");
            var borrowedBooks = API.GET<List<BorrowedBook>>("borrowedBooks");
            var students = API.GET<List<Student>>("students");

            foreach (BorrowedBook borrowedBook in borrowedBooks)
            {
                if (borrowedBook.IsGiven)
                {
                    Book book = books.Where(b => b.ID_Book == borrowedBook.ID_Book).FirstOrDefault();
                    string authorsString = "";
                    foreach (AuthorBook authorBook in authorBooks)
                    {
                        if (authorBook.ID_Book == book.ID_Book) authorsString += $"{authors.Where(a => a.ID_Author == authorBook.ID_Author).FirstOrDefault().GetInitials()}, ";
                    }
                    borrowedBooksGrid.Rows.Add(borrowedBook.ID_BorrowedBook, students.Where(s => s.ID_Student == borrowedBook.ID_Student).FirstOrDefault().GetFIO(), borrowedBook.ReturnDate.ToString("dd.MM.yyyy"), $"\"{book.Name}\"; {authorsString}; {publishings.Where(p => p.ID_PublishingHouse == book.ID_PublishingHouse).FirstOrDefault().Name}; {book.Year}");
                }
            }

            int count = 0;
            foreach (DataGridViewRow row in borrowedBooksGrid.Rows)
            {
                if (DateTime.Parse(row.Cells[2].Value.ToString()) <= DateTime.Today) borrowedBooksGrid.Rows[count].DefaultCellStyle.BackColor = Color.Pink;
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (borrowedBooksGrid.SelectedRows.Count != 0)
            {
                var orderToDelete = API.GET<BorrowedBook>($"borrowedBooks/{borrowedBooksGrid.SelectedRows[0].Cells[0].Value}");
                var book = API.GET<Book>($"books/{orderToDelete.ID_Book}");
                book.Count++;
                API.PUT("books", book, book.ID_Book);
                API.DELETE("borrowedBooks", orderToDelete, orderToDelete.ID_BorrowedBook);
                RefreshGrid();
            }
        }

        private void списокКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminOrders form = new FormAdminOrders();
            form.Owner = this;
            form.ShowDialog();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminReaders form = new FormAdminReaders();
            form.Owner = this;
            form.ShowDialog();
        }

        private void добавитьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminBooks form = new FormAdminBooks();
            form.Owner = this;
            form.ShowDialog();
        }

        private void зарегистрироватьАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminRegistration form = new FormAdminRegistration();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
