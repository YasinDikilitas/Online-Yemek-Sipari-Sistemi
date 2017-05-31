using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class IndirimlerController : Controller
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        // GET: İndirimler
        public ActionResult Index()
        {
            return View(db.Urunlers.Where(x => x.Indirimid!=null));
        }
    }
}