using System.Collections.Generic;
using System.Web.Http;
using WebApp.Models;
using WebApp.Models.Context;

namespace WebApp.Controllers.ApiControllers
{
    public class PurchasesController : ApiController
    {
        BookContext db = new BookContext();

        // GET api/<controller>
        public IEnumerable<Purchase> Get()
        {
            return db.Purchases;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}