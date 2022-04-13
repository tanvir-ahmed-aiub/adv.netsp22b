using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation_WebAPI.Controllers
{
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel login) {
            dynamic token = AuthService.Authenticate(login.Uname, login.Password);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, new { Key = token.TKey, CreatedAt = token.CreatedAt });
            }
            else {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { Msg = "User Not found"});
            }
            
        }
    }
}
