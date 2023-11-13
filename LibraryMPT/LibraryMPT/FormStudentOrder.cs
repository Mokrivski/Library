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
    public partial class FormStudentOrder : Form
    {
        public FormStudentOrder()
        {
            InitializeComponent();
        }

        private void FormStudentOrder_Load(object sender, EventArgs e)
        {
            dateBox.MinDate = DateTime.Today.AddDays(7);
            dateBox.MaxDate = DateTime.Today.AddMonths(2);

            var books = API.GET<List<Book>>("books");
            var publishings = API.GET<List<PublishingHouse>>("publishingHouses");
            var authors = API.GET<List<Author>>("authors");
            var authorBooks = API.GET<List<AuthorBook>>("authorBooks");
            List<BookComboBox> booksCombo = new List<BookComboBox>();
            foreach (Book book in books)
            {
                string authorsString = "";
                foreach (AuthorBook authorBook in authorBooks)
                {
                    if (authorBook.ID_Book == book.ID_Book) authorsString += $"{authors.Where(a => a.ID_Author == authorBook.ID_Author).FirstOrDefault().GetInitials()}, ";
                }
                booksCombo.Add(new BookComboBox(book.ID_Book, $"\"{book.Name}\"; {authorsString}; {publishings.Where(p => p.ID_PublishingHouse == book.ID_PublishingHouse).FirstOrDefault().Name}; {book.Year}"));
            }
            bookBox.DataSource = booksCombo;
            bookBox.DisplayMember = "Name";
            bookBox.ValueMember = "Id";
        }

        private class BookComboBox
        {
            public BookComboBox(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public int Id { get; set; }
            public string Name { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bookBox.SelectedItem != null)
            {
                var book = API.GET<Book>($"books/{int.Parse(bookBox.SelectedValue.ToString())}");
                if (book.Count <= 0)
                {
                    MessageBox.Show("Данной книги пока нет в наличии");
                    return;
                }
                book.Count--;
                API.PUT("books", book, book.ID_Book);
                BorrowedBook borrowedBook = new BorrowedBook(dateBox.Value, ((Owner as FormStudentOrders).Owner as FormStudent).StudentNumber, book.ID_Book, false);
                API.POST("borrowedBooks", borrowedBook);
                (Owner as FormStudentOrders).RefreshGrid();
                Close();
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}
