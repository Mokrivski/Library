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
    public partial class FormAdminBooks : Form
    {
        public FormAdminBooks()
        {
            InitializeComponent();
        }

        private void FormAdminBooks_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            booksGrid.Rows.Clear();

            var books = API.GET<List<Book>>("books");
            var publishings = API.GET<List<PublishingHouse>>("publishingHouses");
            var authors = API.GET<List<Author>>("authors");
            var authorBooks = API.GET<List<AuthorBook>>("authorBooks");

            foreach (Book book in books)
            {
                string authorsString = "";
                foreach (AuthorBook authorBook in authorBooks)
                {
                    if (authorBook.ID_Book == book.ID_Book) authorsString += $"{authors.Where(a => a.ID_Author == authorBook.ID_Author).FirstOrDefault().GetInitials()}, ";
                }
                booksGrid.Rows.Add(book.ID_Book, book.Name, authorsString, publishings.Where(p => p.ID_PublishingHouse == book.ID_PublishingHouse).FirstOrDefault().Name, book.Year, book.Count);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (booksGrid.SelectedRows.Count != 0)
            {
                var bookToDelete = API.GET<Book>($"books/{booksGrid.SelectedRows[0].Cells[0].Value}");
                var authorBooks = API.GET<List<AuthorBook>>("authorBooks");
                var borrowedBooks = API.GET<List<BorrowedBook>>("borrowedBooks");

                foreach (AuthorBook authorBook in authorBooks)
                {
                    if (authorBook.ID_Book == bookToDelete.ID_Book) API.DELETE("authorBooks", authorBook, authorBook.ID_AuthorBook);
                }
                foreach (BorrowedBook borrowedBook in borrowedBooks)
                {
                    if (borrowedBook.ID_Book == bookToDelete.ID_Book) API.DELETE("borrowedBooks", borrowedBook, borrowedBook.ID_BorrowedBook);
                }

                API.DELETE("books", bookToDelete, bookToDelete.ID_Book);
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminBookEdit form = new FormAdminBookEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (booksGrid.SelectedRows.Count != 0)
            {
                FormAdminBookEdit form = new FormAdminBookEdit(int.Parse(booksGrid.SelectedRows[0].Cells[0].Value.ToString()));
                form.Owner = this;
                form.ShowDialog();
            }
        }
    }
}
