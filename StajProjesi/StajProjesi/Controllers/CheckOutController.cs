using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class CheckOutController : BaseController
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        // GET: CheckOut
        public ActionResult Index()
        {

            var urun = db.Urunlers.Where(x => x.Sepetid == 2);
            return View(urun);
        }

        [HttpPost]
        public ActionResult Index(Urunler urun)
        {
            var deger = db.Urunlers.Find(urun.id);
            deger.Sepetid = 3;
            db.SaveChanges();
            return Redirect("/");
        }
    }
}