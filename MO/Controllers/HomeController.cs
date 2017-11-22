using MOModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

                    return View("Tutorial", JsonConvert.DeserializeObject<Tutorial>(result));
                }
            }

        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Tutorial newTutorial)
        {
                if (newTutorial != null)
            {
                using (var client = new HttpClient())
                {
                    var myContent = JsonConvert.SerializeObject(newTutorial);
                    var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                    var byteContent = new ByteArrayContent(buffer);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    using (var r = await client.PostAsync(new Uri("http://localhost:51182/api/Tutorial/"), byteContent))
                    {
                        return View();
                    }
                }
            }
            return View();
        }
    }

}