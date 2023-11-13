using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class BorrowedBook
    {
        [Key]
        public int ID_BorrowedBook { get; set; }
        public DateTime ReturnDate { get; set; }
        public int ID_Student { get; set; }
        public int ID_Book { get; set; }
        public bool IsGiven { get; set; }
    }
}
