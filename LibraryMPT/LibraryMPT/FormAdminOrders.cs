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
    public partial class FormAdminOrders : Form
    {
        public FormAdminOrders()
        {
            InitializeComponent();
        }

        private void FormAdminOrders_Load(object sender, EventArgs e)
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
                if (!borrowedBook.IsGiven)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (borrowedBooksGrid.SelectedRows.Count != 0)
            {
                var orderToGive = API.GET<BorrowedBook>($"borrowedBooks/{borrowedBooksGrid.SelectedRows[0].Cells[0].Value}");
                orderToGive.IsGiven = true;
                API.PUT("borrowedBooks", orderToGive, orderToGive.ID_BorrowedBook);
                (Owner as FormAdmin).RefreshGrid();
                Close();
            }
        }
    }
}
