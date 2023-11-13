using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Student
    {
        [Key]
        public int ID_Student { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
