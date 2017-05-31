using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class UrunlerController : BaseController
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        // GET: Urunler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detay(int id)
        {
            var urunlerrr = db.Urunlers.FirstOrDefault(x => x.id == id);
            return View(urunlerrr);
        }
        [HttpPost]
        public ActionResult Detay(Urunler urun)
        {
            var mevcut = db.Urunlers.Find(urun.id);
            mevcut.Sepetid = 2;
            db.SaveChanges();
            return Redirect("/CheckOut/");
        }
        public ActionResult SatinAl(string id)
        {
            var satinal = db.Urunlers.FirstOrDefault(x => x.Baslik == id);
            return View(satinal);
        }

        [HttpPost]
        public ActionResult SatinAl(string urun, string mail, string isim, string telefon, string mesaj)
        {
            if(urun==null)
            {
                MesajBox ms = new MesajBox();
                ms.AdSoyad = isim;
                ms.Mail = mail;
                ms.Telefon = telefon;
                ms.Mesaj = mesaj;
                ms.Urun = "Bu bir mesajdır.";
                db.MesajBoxes.Add(ms);
                db.SaveChanges();
                return Redirect("/");
            }
            else
            {
                MesajBox ms = new MesajBox();
                ms.AdSoyad = isim;
                ms.Mail = mail;
                ms.Telefon = telefon;
                ms.Mesaj = mesaj;
                ms.Urun = urun;
                db.MesajBoxes.Add(ms);
                db.SaveChanges();
                return Redirect("/");
            }
       
        }
    }
}