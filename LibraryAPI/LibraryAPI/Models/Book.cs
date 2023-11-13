using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Book
    {
        [Key]
        public int ID_Book { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public int Count { get; set; }
        public int ID_PublishingHouse { get; set; }
    }
}
