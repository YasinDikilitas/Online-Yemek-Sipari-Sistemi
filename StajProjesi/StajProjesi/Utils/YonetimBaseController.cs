using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Utils
{
    public class YonetimBaseController:System.Web.Mvc.Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            string actionName = filterContext.RouteData.Values["action"].ToString();
            bool isControl = controllerName == "YonetimController" && actionName == "Yonetim";
            if (isControl)
            { 
            if (Session["Admina"] == null || Session["Admina"].ToString() != "1")
                {
                    filterContext.Result = new RedirectResult("/Yonetim/");
                    return;
                }
            
        }
            base.OnActionExecuting(filterContext);
        }
    }
}