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
    public partial class FormStudentOrders : Form
    {
        public FormStudentOrders()
        {
            InitializeComponent();
        }

        private void FormStudentOrders_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void FormStudentOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Owner as FormStudent).logout = false;
        }

        public void RefreshGrid()
        {
            booksGrid.Rows.Clear();
            var books = API.GET<List<Book>>("books");
            var publishings = API.GET<List<PublishingHouse>>("publishingHouses");
            var authors = API.GET<List<Author>>("authors");
            var authorBooks = API.GET<List<AuthorBook>>("authorBooks");
            var borrowedBooks = API.GET<List<BorrowedBook>>("borrowedBooks");

            foreach (BorrowedBook book in borrowedBooks)
            {
                if (book.ID_Student == (Owner as FormStudent).StudentNumber && !book.IsGiven)
                {
                    Book currentBook = books.Where(b => b.ID_Book == book.ID_Book).FirstOrDefault();
                    string authorsString = "";
                    foreach (AuthorBook authorBook in authorBooks)
                    {
                        if (authorBook.ID_Book == book.ID_Book) authorsString += $"{authors.Where(a => a.ID_Author == authorBook.ID_Author).FirstOrDefault().GetInitials()}, ";
                    }
                    booksGrid.Rows.Add(book.ID_BorrowedBook, book.ReturnDate.ToString("dd.MM.yyyy"), currentBook.Name, currentBook.Year, publishings.Where(p => p.ID_PublishingHouse == currentBook.ID_PublishingHouse).FirstOrDefault().Name, authorsString);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (booksGrid.SelectedRows.Count != 0)
            {
                var orderToDelete = API.GET<BorrowedBook>($"borrowedBooks/{booksGrid.SelectedRows[0].Cells[0].Value}");
                var book = API.GET<Book>($"books/{orderToDelete.ID_Book}");
                book.Count++;
                API.PUT("books", book, book.ID_Book);
                API.DELETE("borrowedBooks", orderToDelete, orderToDelete.ID_BorrowedBook);
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudentOrder form = new FormStudentOrder();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
