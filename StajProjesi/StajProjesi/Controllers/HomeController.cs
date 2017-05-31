using StajProjesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using StajProjesi.Utils;

namespace StajProjesi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        StajProjeEntities2 db = new StajProjeEntities2();
        public ActionResult Index(int? page)
        {
            var urunlerr = db.Urunlers.Where(x => x.id > 0).ToList().ToPagedList(page ?? 1,8);
            return View(urunlerr);
        }
        public ActionResult Slider()
        {
            var sliders=db.Mansets.Where(x => x.id > 0);
            return View(sliders);
        }
        public ActionResult UrunGetir()
        {
            var urunlerr = db.Urunlers.Where(x => x.id > 0);
            return View(urunlerr);
        }

      
    }
}