using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Auth
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AdminAccess :AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            var auth = false;
            if (httpContext.Session["UserName"] != null) {
                auth = true;
            }
            if (auth && httpContext.Session["UserType"].Equals("Admin")) {
                return true;
            }
            return false;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Redirect("/home/contact");
        }
    }
}