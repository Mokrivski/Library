namespace LibraryMPT.Models
{
    public class PublishingHouse
    {
        public PublishingHouse(string name)
        {
            Name = name;
        }

        public int ID_PublishingHouse { get; set; }
        public string Name { get; set; }
    }
}
