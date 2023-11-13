using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class PublishingHouse
    {
        [Key]
        public int ID_PublishingHouse { get; set; }
        public string Name { get; set; }
    }
}
