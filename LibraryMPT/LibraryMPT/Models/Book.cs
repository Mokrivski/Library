namespace LibraryMPT.Models
{
    public class Book
    {
        public Book(string name, string year, int count, int iD_PublishingHouse)
        {
            Name = name;
            Year = year;
            Count = count;
            ID_PublishingHouse = iD_PublishingHouse;
        }

        public int ID_Book { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public int Count { get; set; }
        public int ID_PublishingHouse { get; set; }
    }
}
