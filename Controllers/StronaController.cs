using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class StronaController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "DOS Games.";

            return View();
        }

        public ActionResult Programy()
        {
            ViewBag.Message = "DOS Games description page.";

            return View();
        }

        public ActionResult Kontakt()
        {
            ViewBag.Message = "DOS Games contact page.";

            return View();
        }
    }
}
