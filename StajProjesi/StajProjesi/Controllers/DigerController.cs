using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class DigerController : Controller
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        // GET: Diger
        public ActionResult Index()
        {
            return View(db.Urunlers.Where(x => x.Kategori == 3));
        }
        public ActionResult Tatli()
        {
            return View(db.Urunlers.Where(x => x.Kategori == 4));
        }
    }
}