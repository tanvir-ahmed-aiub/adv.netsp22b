using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroMVC.Models;

namespace IntroMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
       public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register() {
            return View();
        }
        public ActionResult Ind() {

            /*var p = new Person();
            p.Id = 1;
            p.Name = "Person 1";*/

            var p = new Person {
                Id = 1,
                Name = "Rakib",
                Dob = DateTime.Now
            };
            return View(p);
        }
        public ActionResult Home() {

            /*ViewBag.Name = "Tanvir";
            ViewBag.Id = "12";
            ViewBag.Dob = "12.12.12";

            ViewData["Name"] = "Sabbir";
            ViewData["Id"] = 13;
            ViewData["Dob"] = "12.12.12";*/
            /*string[] names = {"Tanvir","Dipok","Rupok","Shoaib" };
            ViewBag.Names = names;*/
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 100; i++) {

                /*var p = new Person();
                p.Name = "Person " + (i + 1);
                p.Id = i + 1;*/

                var p = new Person() { 
                    Id = i+1,
                    Name = "Person "+(i+1),
                    Dob = DateTime.Now

                };

                persons.Add(p);
            }

            return View(persons);

        }


    }
}