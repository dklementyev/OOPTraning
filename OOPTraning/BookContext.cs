namespace OOPTraning
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Entities;

    public class BookContext : DbContext
    {
        public BookContext()
            : base("LibraryDb")
        {
        }
        public DbSet<Book> Books { get; set; }
    }

}