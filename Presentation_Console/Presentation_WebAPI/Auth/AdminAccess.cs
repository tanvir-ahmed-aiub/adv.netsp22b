using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Presentation_WebAPI.Auth
{
    public class AdminAccess:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NotFound, "No token supplied");
            }
            else {
                if (!AuthService.ValidateToken(token.ToString())) {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden, "Token Expired");
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}