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
            List<Game>[] top5Games = new List<Game>[20];
            var groupedGames = db.Games
                .GroupBy(s => s.CategoryID)
                .Select (g => g.Take (5));

            groupedGames.ToList().ForEach(s =>
            {
                top5Games[s.First().CategoryID] = s.ToList();
            });

            ViewData["Cats"] = db.Categories
                .OrderBy(s => s.CategoryPL)
                .ToList();
                
            ViewData["ViewCatGam"] = top5Games;
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