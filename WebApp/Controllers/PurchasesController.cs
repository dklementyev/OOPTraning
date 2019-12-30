using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PurchasesController : Controller
    {
        // GET: Purchases
        public async Task<ActionResult> Index()
        {
            var baseURI = Request.Url.GetLeftPart(UriPartial.Authority) + @"/api/purchases";
            var purchases = new List<Purchase>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURI);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = await client.GetAsync(baseURI);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    purchases = JsonConvert.DeserializeObject<List<Purchase>>(data);
                }
            }

            return View(purchases);
        }
    }
}