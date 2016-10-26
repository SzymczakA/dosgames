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
    public class GryController : Controller
    {
        private GameDBCtxt db = new GameDBCtxt();

        public ActionResult Wszystkie()
        {
            var games = db.Games;
            ViewBag.GamList = games.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Szukaj(string Find)
        {
           var games = from i in db.Games
                      select i;
           if (!String.IsNullOrEmpty(Find))
           {
                games = from i in db.Games
                     where i.FullName.Contains(Find)
                     select i;
           }
           ViewBag.GamList = games.ToList();
           return View();
        }

        public ActionResult Pobierz(int id = 0)
        {
            Game game = db.Games.Find(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            game.Popularity++;
            List<String> LinkList = new List<String>();
            LinkList.Add("http://dos.16mb.com/?gra=" + game.Name);
            LinkList.Add("http://asnet.cba.pl/?gra=" + game.Name);
            LinkList.Add(game.Link);
            db.SaveChanges();
            
            ViewBag.GamLink = LinkList;
            return View(game);
        }

        

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}