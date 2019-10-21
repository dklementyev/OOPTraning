using OOPTraning.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTraning
{
    public class SQLBookRepository : ILibraryRepository<Book>
    {
        private BookContext bookContext;
        private bool disposed;
        public SQLBookRepository()
        {
            this.bookContext = new BookContext();
        }

        public void Create(Book item)
        {
            bookContext.Books.Add(item);
        }

        public void Delete(int id)
        {
            Book book = bookContext.Books.Find(id);
            if (book != null)
                bookContext.Books.Remove(book);
        }

        public virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if (disposing)
                    bookContext.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Book GetItem(int id)
        {
            return bookContext.Books.Find(id);
        }

        public IEnumerable<Book> GetItems()
        {
            return bookContext.Books;
        }

        public void Save()
        {
            bookContext.SaveChanges();
        }

        public void Update(Book item)
        {
            bookContext.Entry(item).State = EntityState.Modified;
        }
    }
}
