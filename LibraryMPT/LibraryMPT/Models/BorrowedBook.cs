using System;

namespace LibraryMPT.Models
{
    public class BorrowedBook
    {
        public BorrowedBook(DateTime returnDate, int iD_Student, int iD_Book, bool isGiven)
        {
            ReturnDate = returnDate;
            ID_Student = iD_Student;
            ID_Book = iD_Book;
            IsGiven = isGiven;
        }

        public int ID_BorrowedBook { get; set; }
        public DateTime ReturnDate { get; set; }
        public int ID_Student { get; set; }
        public int ID_Book { get; set; }
        public bool IsGiven { get; set; }
    }
}
