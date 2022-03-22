using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPIIntro.Models;

namespace WEBAPIIntro.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/dept/all")]
        [HttpGet]
        public HttpResponseMessage AllDept() {
            return Request.CreateResponse(HttpStatusCode.OK, "data");
        }

        [Route("api/dept/add")]
        [HttpPost]
        public HttpResponseMessage AddDept(Department d) {
            return Request.CreateResponse(HttpStatusCode.OK, "posted");
        }
    }
}
