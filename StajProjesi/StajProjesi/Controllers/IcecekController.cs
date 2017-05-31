using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class IcecekController : Controller
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        // GET: Masaüstü
        public ActionResult Index()
        {
            return View(db.Urunlers.Where(x => x.Kategori == 2));
        }
    }
}