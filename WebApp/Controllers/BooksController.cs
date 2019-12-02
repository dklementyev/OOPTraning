using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Controllers.ApiResponses;
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
        public HttpResponseMessage Get(int id)
        {
            var book = db.Find<Book>(id);
            if (book == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new ErrorResponseModel() { ErrorCode = HttpStatusCode.NotFound.ToString(), ErrorMessage = "Book with id wasn't founded." });
            }
            return Request.CreateResponse(HttpStatusCode.OK, book);
            ;
        }

        // POST api/values
        public void Post([FromBody]Book book)
        {
            db.Add(book);
            db.SaveChanges();
        }

        // PUT api/values/5
        public HttpResponseMessage Put(int id, [FromBody]Book book)
        {
            var bookFromDb = db.Find<Book>(id);
            if (bookFromDb != null)
            {
                bookFromDb.Name = book.Name;
                bookFromDb.Author = book.Author;
                bookFromDb.LendCost = book.LendCost;
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, bookFromDb);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new ErrorResponseModel() { ErrorCode = HttpStatusCode.NotFound.ToString(), ErrorMessage = "Book with id wasn't founded." });
            }
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            var book = db.Find<Book>(id);
            if (book == null)
                return Request.CreateResponse(HttpStatusCode.NotFound, new ErrorResponseModel() { ErrorCode = HttpStatusCode.NotFound.ToString(), ErrorMessage = "Book with id wasn't founded." });

            db.Remove<Book>(book);

            db.SaveChanges();
            if (db.Find<Book>(id) == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new ErrorResponseModel() { ErrorCode = HttpStatusCode.NotFound.ToString(), ErrorMessage = "Book with id wasn't founded." });
            }

        }
    }
}