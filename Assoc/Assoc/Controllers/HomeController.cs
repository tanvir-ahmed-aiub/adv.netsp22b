using Assoc.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Assoc.Models.Entity;

namespace Assoc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UMS_Sp22_BEntities db = new UMS_Sp22_BEntities();
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
            var students = dept.Students.ToList();

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