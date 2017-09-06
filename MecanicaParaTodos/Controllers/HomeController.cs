using System;
using MecanicaParaTodos.Models;
using MecanicaParaTodos.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MecanicaParaTodos.Controllers
{
    public class HomeController : Controller
    {
        public TutorialRepository _repo;

        public HomeController()
        {
            _repo = new TutorialRepository();
        }
        public ActionResult Index()
        {
            var model = _repo.GetAll();
            return View(model);
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
    }
}