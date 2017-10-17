using MOModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MO.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(new Uri("http://localhost:51182/api/Tutorial/")))
                {
                    string result = await r.Content.ReadAsStringAsync();

                    return View(JsonConvert.DeserializeObject<IEnumerable<Tutorial>>(result));
                }
            }
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

        public ActionResult Tutorial(Tutorial t)
        {
            ViewBag.Message = "Your contact page.";

            return View(t);
        }

        public async Task<ActionResult> GetTutorialById(int id)
        {
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(new Uri("http://localhost:51182/api/Tutorial/" + id)))
                {
                    string result = await r.Content.ReadAsStringAsync();

                    return RedirectToAction("Tutorial", JsonConvert.DeserializeObject<Tutorial>(result));
                }
            }
        }
    }
}