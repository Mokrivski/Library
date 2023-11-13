using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<BorrowedBook> BorrowedBook { get; set; }
        public DbSet<PublishingHouse> PublishingHouse { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
