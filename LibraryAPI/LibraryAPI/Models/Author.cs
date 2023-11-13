using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Author
    {
        [Key]
        public int ID_Author { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
    }
}
