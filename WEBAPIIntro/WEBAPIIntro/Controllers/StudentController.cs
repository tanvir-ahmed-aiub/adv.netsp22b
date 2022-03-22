using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Script.Serialization;
using WEBAPIIntro.Models;

namespace WEBAPIIntro.Controllers
{
    [EnableCors("*","*","*")]
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get() {
            List<Student> students = new List<Student>();
            for(int i = 1; i <= 10; i++)
            {
                var s = new Student() { 
                    Id = ""+i,
                    Name = "Student "+i
                };
                students.Add(s);
            }
            //var data = new JavaScriptSerializer().Serialize(students);
            return Request.CreateResponse(HttpStatusCode.OK,students);
        }
        public Student Get(string id) {
            List<Student> students = new List<Student>();
            for (int i = 1; i <= 10; i++)
            {
                var s = new Student()
                {
                    Id = "" + i,
                    Name = "Student " + i
                };
                students.Add(s);
            }
            var st = students.FirstOrDefault(x => x.Id.Equals(id));
            return st;

        }
        public void Post()
        {

        }
        public void Delete()
        {

        }
        public void Put()
        {

        }
    }
}
