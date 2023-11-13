namespace LibraryMPT.Models
{
    public class Author
    {
        public Author(string surname, string name, string middlename)
        {
            Surname = surname;
            Name = name;
            Middlename = middlename;
        }

        public int ID_Author { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }

        public string GetInitials()
        {
            if (Middlename.Length != 0) return $"{Surname} {Name[0]}.{Middlename[0]}.";
            else return $"{Surname} {Name[0]}.";
        }
    }
}
