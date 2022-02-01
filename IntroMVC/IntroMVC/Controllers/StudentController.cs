using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create() 
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Create(Student s) 
        {
            if (ModelState.IsValid)
            {
                //db insertion or authentication authorization
                return RedirectToAction("Home", "Person");
            }
            return View(s);
        }
        
        [HttpPost]
        public ActionResult Submit() 
        {
            return View();
            /*if (ModelState.IsValid)
            {
                return View(s);
            }
            return RedirectToAction("Create");*/
            /*ViewBag.Name = Request["Name"];
            ViewBag.Id = Request["Id"];
            ViewBag.Dob = Request["Dob"];
            ViewBag.Email = Request["Email"];*/

            /*ViewBag.Name = form["Name"];
            ViewBag.Id = form["Id"];
            ViewBag.Dob = form["Dob"];
            ViewBag.Email = form["Email"];*/
            /*ViewBag.Name = Name;
            ViewBag.Id = Id;
            ViewBag.Dob = Dob;
            ViewBag.Email = Email;*/

            
        }
    }
}