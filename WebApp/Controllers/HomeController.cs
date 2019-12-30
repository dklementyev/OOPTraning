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
            return RedirectToAction("Index", "Books");
        }

      
       
    }
}