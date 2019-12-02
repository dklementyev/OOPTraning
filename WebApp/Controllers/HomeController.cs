using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.Models.Context;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        BookContext db = new BookContext();

        public async Task<ActionResult> Index()
        {
            var baseURI = HttpContext.Request.Url + @"api/books";
            var books = new List<Book>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = await client.GetAsync(baseURI);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    books = JsonConvert.DeserializeObject<List<Book>>(data);
                }
            }
            return View(books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Thanks," + purchase.NickName + ", for your purchase!";
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public string AddBook(string bookName = "1")
        {
            return "Thanks for creation book!";
        }

    }
}