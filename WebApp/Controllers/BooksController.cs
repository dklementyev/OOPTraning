using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;
using WebApp.Models.Context;

namespace WebApp.Controllers
{
    public class BooksController : ApiController
    {
        BookContext db = new BookContext();

        // GET api/values
        public IEnumerable<Book> Get()
        {
            return db.Books;
        }

        // GET api/values/5
        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        // POST api/values
        public void Post([FromBody]Book book)
        {
            db.Add(book);
            db.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Book book)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}