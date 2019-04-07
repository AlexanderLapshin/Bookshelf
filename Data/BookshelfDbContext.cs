using Models;
using System.Data.Entity;

namespace Data
{
    public class BookshelfDbContext : DbContext
    {
        public BookshelfDbContext() : base("bookshelfDb")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookshelfDbContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
