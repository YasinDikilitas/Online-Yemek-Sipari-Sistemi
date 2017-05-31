using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class AnaYemekController : Controller
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        // GET: Laptop
        public ActionResult Index()
        {
            return View(db.Urunlers.Where(x=>x.Kategori==1));
        }
    }
}