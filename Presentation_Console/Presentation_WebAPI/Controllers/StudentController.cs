using BLL.Services;
using Presentation_WebAPI.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation_WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/student/{id}")]
        public HttpResponseMessage Get(int id) {
            var st = StudentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
        [AdminAccess]
        [HttpGet]
        [Route("api/student/")]
        public HttpResponseMessage Get() {
            var st = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);

        }
    }
}
