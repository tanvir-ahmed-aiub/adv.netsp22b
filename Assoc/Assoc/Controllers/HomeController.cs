using Assoc.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Assoc.Models.Entity;
using System.Web.Security;
using Assoc.Auth;

namespace Assoc.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        //[AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
           /* UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            var dept = (from d in db.Departments
                        where d.Id == 1
                        select d).FirstOrDefault();
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<Department, DepartmentStudentModel>();
                    cfg.CreateMap<Student, StudentModel>();
               
                }   
                );
            var mapper = new Mapper(config);
            var deptModel = mapper.Map<DepartmentStudentModel>(dept);

            var courses = dept.Courses.ToList();
            var students = dept.Students.ToList();*/

            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel user)
        {
            
            if (ModelState.IsValid)
            {
                UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
                var data = (from u in db.Users
                            where u.Username.Equals(user.Username) &&
                            u.Password.Equals(user.Password)
                            select u).FirstOrDefault();
                if (data != null)
                {
                    FormsAuthentication.SetAuthCookie(data.Username, false); //for default authorization
                    //Session["UserType"] = data.Role;
                   // FormsAuthentication.SignOut(); for logout
                    return RedirectToAction("Dashboard");
                }

            }
            return View();
        }
        [Authorize]
        public ActionResult Dashboard() {
            
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<Department, DepartmentModel>();
                    
                }
                );
            var deptDb = db.Departments.ToList();
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<List<DepartmentModel>>(deptDb);
            return View(data);
        }

        [AdminAccess]
        public ActionResult AllUsers() {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<User, UserModel>();

                }
                );
            var deptDb = db.Users.ToList();
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<List<UserModel>>(deptDb);
            return View(data);
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