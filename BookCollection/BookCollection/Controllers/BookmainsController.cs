using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookCollection.Models;

namespace BookCollection.Controllers
{
    public class BookmainsController : Controller
    {
        // GET: Bookmains
        [HttpGet]
        public ActionResult Bookfront()
        {
            Bookstore bs = new Bookstore();

            return View(bs);
        }
        [HttpPost]
        public ActionResult Bookfront(Bookstore bs)
        {
            DBOneModelstwo dbm2 = new DBOneModelstwo();
            var name = dbm2.Bookstores.Where(oh => oh.BookTitle.Contains(bs.Search)).ToList();
            ViewBag.allsearch = name;
            return View("SearchedBooks");

        }

        [HttpPost]
        public ActionResult SearchedBooks(string id)
        {
            DBOneModelstwo dbm4 = new DBOneModelstwo();
            var result = Convert.ToInt32(id);
            var isfav = (from y in dbm4.Bookstores where y.BookId == result select y).FirstOrDefault();
            isfav.favourite = 1;
            dbm4.SaveChanges();

            return LikeBook();
        }

        public ActionResult LikeBook()
        {
            DBOneModelstwo dbm5 = new DBOneModelstwo();
            var liketab = (from z in dbm5.Bookstores where z.favourite == 1 select z).ToList();
            ViewBag.favs = liketab;
            return View("FavouriteBooks");
        }

        [HttpGet]
        public ActionResult Addbooks()
        {
            Bookstore bs = new Bookstore();

            return View(bs);
        }
        [HttpPost]
        public ActionResult Addbooks(Bookstore bs)
        {
            DBOneModelstwo dbm1 = new DBOneModelstwo();
            dbm1.Bookstores.Add(bs);
            dbm1.SaveChanges();
            return RedirectToAction("Bookfront", "Bookmains");
        }

    }
}