using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class KategorieController : Controller
    {

        private GameDBCtxt db = new GameDBCtxt();
        public ActionResult Wszystkie()
        {
            List<Category> CatList = db.Categories.ToList();
            ViewData["Cats"] = CatList;                
            var Gam5 = from i in db.Games
                          select i;
            List<Game>[] CatGam = new List<Game>[20];
            for (int i = 0; i < CatList.Count; i++) {
                Category tmp = CatList.ElementAt(i);
                List<Game> GamList = Gam5.Where(p => p.CategoryID.Equals(tmp.CategoryID)).ToList();
                CatGam[i+1] = GamList.GetRange(0, GamList.Count < 5 ? GamList.Count : 5);
            }
            ViewData["ViewCatGam"] = CatGam;
                return View();       
        }

        public ActionResult Kategoria(int id = 0)
        {
            Category CatList = db.Categories.Find(id);;
            ViewData["Cat"] = CatList;
            var CatGam = from i in db.Games
                      where i.CategoryID.Equals(id)
                      select i;
            ViewData["ViewCatGam"] = CatGam;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}