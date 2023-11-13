namespace LibraryMPT.Models
{
    public class Admin
    {
        public Admin(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public int ID_Admin { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
