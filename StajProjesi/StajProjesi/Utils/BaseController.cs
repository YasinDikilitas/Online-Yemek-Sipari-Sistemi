using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Utils
{
    public class BaseController:System.Web.Mvc.Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            string actionName = filterContext.RouteData.Values["action"].ToString();
            bool isControl = controllerName == "UrunlerController" && actionName == "Index";
            bool isControl2 = controllerName == "UrunlerController" && actionName == "Detay";
            bool isControl3 = controllerName == "UrunlerController" && actionName == "SatinAl";
                if (!isControl3)
                {

                    if (Session["Admin"] == null || Session["Admin"].ToString() != "1")
                    {
                        filterContext.Result = new RedirectResult("/Kullanici/Giris");
                        return;
                    }

                }
           
            base.OnActionExecuting(filterContext);
        }
    }
}