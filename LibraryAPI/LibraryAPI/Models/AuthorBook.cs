using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class AuthorBook
    {
        [Key]
        public int ID_AuthorBook { get; set; }
        public int ID_Book { get; set; }
        public int ID_Author { get; set; }
    }
}
