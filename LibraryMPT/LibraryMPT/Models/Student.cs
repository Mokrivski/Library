using System;

namespace LibraryMPT.Models
{
    public class Student
    {
        public Student(string surname, string name, string middlename, string phoneNumber, string login, string password, DateTime birthdate)
        {
            Surname = surname;
            Name = name;
            Middlename = middlename;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
            Birthdate = birthdate;
        }

        public int ID_Student { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthdate { get; set; }

        public string GetFIO()
        {
            return $"{Surname} {Name} {Middlename} (Билет №{ID_Student})";
        }
    }
}
