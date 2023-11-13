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
    public partial class FormStudent : Form
    {
        public int StudentNumber;
        public bool logout = false;

        public FormStudent(int studentNumber)
        {
            InitializeComponent();
            StudentNumber = studentNumber;
            numberLabel.Text = $"Номер вашего читательского билета: {studentNumber}";
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            Form1 form = Owner as Form1;
            form.Show();
            Close();
        }

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout)
            {
                Application.Exit();
            }
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            booksGrid.Rows.Clear();
            var books = API.GET<List<Book>>("books");
            var publishings = API.GET<List<PublishingHouse>>("publishingHouses");
            var authors = API.GET<List<Author>>("authors");
            var authorBooks = API.GET<List<AuthorBook>>("authorBooks");
            var borrowedBooks = API.GET<List<BorrowedBook>>("borrowedBooks");

            foreach (BorrowedBook book in borrowedBooks)
            {
                if (book.ID_Student == StudentNumber && book.IsGiven)
                {
                    Book currentBook = books.Where(b => b.ID_Book == book.ID_Book).FirstOrDefault();
                    string authorsString = "";
                    foreach (AuthorBook authorBook in authorBooks)
                    {
                        if (authorBook.ID_Book == book.ID_Book) authorsString += $"{authors.Where(a => a.ID_Author == authorBook.ID_Author).FirstOrDefault().GetInitials()}, ";
                    }
                    booksGrid.Rows.Add(book.ReturnDate.ToString("dd.MM.yyyy"), currentBook.Name, currentBook.Year, publishings.Where(p => p.ID_PublishingHouse == currentBook.ID_PublishingHouse).FirstOrDefault().Name, authorsString);
                }
            }

            int count = 0;
            foreach(DataGridViewRow row in booksGrid.Rows)
            {
                if (DateTime.Parse(row.Cells[0].Value.ToString()) <= DateTime.Today) booksGrid.Rows[count].DefaultCellStyle.BackColor = Color.Pink;
                count++;
            }
        }

        private void моиЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            FormStudentOrders form = new FormStudentOrders();
            form.Owner = this;
            form.Show();
        }
    }
}
