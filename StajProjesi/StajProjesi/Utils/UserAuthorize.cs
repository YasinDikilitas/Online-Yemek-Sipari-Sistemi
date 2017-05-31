using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Utils
{
    public class UserAuthorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.Cookies["user"] != null)
            {
                return true;
            }
            else
            {
                httpContext.Response.Redirect("/Yonetim/");
                return false;
            }

        }

    }
}