using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class KullaniciController : Controller
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        // GET: Kullanici
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string isim,string soyad,string mail,string sifre)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = isim;
            kullanici.Soyad = soyad;
            kullanici.Mail = mail;
            kullanici.Sifre = sifre;
            db.Kullanicis.Add(kullanici);
            db.SaveChanges();
            return Redirect("/");
            
        }
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(string mail, string pass)
        {
            var deger = db.Kullanicis.Where(x => x.Mail == mail && x.Sifre == pass).FirstOrDefault();
            if (deger != null)
            {
                Session["username"] = deger.Ad;
                Session["lastname"] = deger.Soyad;
                Session["id"] = deger.id;
                Session["Admin"] = "1";
                Response.Redirect("/");
            }
            else
            {
                Response.Redirect("/Kullanici/Giris");
            }
            return View(deger);
        }
    }
}