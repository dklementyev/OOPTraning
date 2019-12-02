using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace WebApp.Models.Context
{
    public class BookContext : DbContext
    {
        public BookContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["LibraryDb"].ConnectionString;
                optionsBuilder.UseMySQL(connectionString);
            }
            //optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=");
        }

    }
}