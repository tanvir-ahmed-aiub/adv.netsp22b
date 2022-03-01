using Practice.Models.Database;
using Practice.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class HomeController : Controller

    {
        [HttpGet]
        public ActionResult Registration() {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Registration(UserModel user) {
            if (ModelState.IsValid) {
                var db = new Entities();
                var u = new User();
                u.Password = user.Password;
                u.Username = user.Username;
                u.Type = "Customer";
                db.Users.Add(u);
                db.SaveChanges();
                var cus = new Customer();
                cus.UserId = u.Id;
                cus.Password = u.Password;
                db.Customers.Add(cus);
                db.SaveChanges();
                return RedirectToAction("Registration");
                /*var db = new Entities();
                var u = (from e in db.Users
                         where e.Username.Equals(user.Username) &&
                         e.Password.Equals(user.Password)
                         select e).FirstOrDefault();
                if (u != null) { 
                
                }*/

            }
            return View(user);
        }

        [HttpGet]
        public ActionResult Login() {

            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel user) {
            if (ModelState.IsValid) {
                var db = new Entities();
                var u = (from e in db.Users
                         where e.Username.Equals(user.Username) &&
                         e.Password.Equals(user.Password)
                         select e).FirstOrDefault();
                if (u != null)
                {
                    Session["UserName"] = u.Username;
                    Session["UserType"] = u.Type;
                    if (u.Type.Equals("Customer"))
                    {
                        
                        //Customer Dashboard
                    }
                    else if (u.Type.Equals("Admin")) {
                        return RedirectToAction("Dashboard","Admin");
                        //Admin Dashboard
                    }
                }
            }
            return View();
        }
        public ActionResult Index()
        {
            return View();
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