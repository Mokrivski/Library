using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class Admin
    {
        [Key]
        public int ID_Admin { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
