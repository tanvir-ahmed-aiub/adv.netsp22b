using EF.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            //db retrival
            sp22BEntities db = new sp22BEntities();
            var data = db.Books.ToList();
            return View(data);
        }
        public ActionResult HighPrice()
        {
            sp22BEntities db = new sp22BEntities();
            var data = (from b in db.Books
                        where b.Price > 500
                        select b).ToList();
        }
        [HttpGet]
        public ActionResult Create() 
        {
            return View(new Book());
        }
        [HttpPost]
        public ActionResult Create (Book b)      
        { 
            if (ModelState.IsValid)
            {
                sp22BEntities db = new sp22BEntities();
                db.Books.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}