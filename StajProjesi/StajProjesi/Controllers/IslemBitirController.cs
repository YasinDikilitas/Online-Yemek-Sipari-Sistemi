using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class IslemBitirController : BaseController
    {
        // GET: IslemBitir
        StajProjeEntities2 db = new StajProjeEntities2();
        public ActionResult Index()
        {
            var satinalinanlar = db.Urunlers.FirstOrDefault(x => x.SepetBilgi.sepetdurum == true);
            return View(satinalinanlar);

        }
        [HttpPost]
        public ActionResult Index(Urunler urun)
        {
            return View();
            
        }

    }
}