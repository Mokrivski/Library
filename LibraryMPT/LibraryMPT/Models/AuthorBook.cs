namespace LibraryMPT.Models
{
    public class AuthorBook
    {
        public AuthorBook(int iD_Book, int iD_Author)
        {
            ID_Book = iD_Book;
            ID_Author = iD_Author;
        }

        public int ID_AuthorBook { get; set; }
        public int ID_Book { get; set; }
        public int ID_Author { get; set; }
    }
}
