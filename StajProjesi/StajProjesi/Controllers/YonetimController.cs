using StajProjesi.Models;
using StajProjesi.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StajProjesi.Controllers
{
    public class YonetimController : Controller
    {
        StajProjeEntities2 db = new StajProjeEntities2();
        [UserAuthorize]
        public ActionResult Mesaj()
        {
            return View(db.MesajBoxes.ToList());
        }
        // GET: Yonetim
        
        public ActionResult Index()
        {
            return View();
        }

        [UserAuthorize]
        string ResimKaydet(HttpPostedFileBase file)
        {
            Image orj = Image.FromStream(file.InputStream);
            string yol = Path.GetFileNameWithoutExtension(file.FileName)+Guid.NewGuid()+Path.GetExtension(file.FileName);
            orj.Save(Server.MapPath("~/Content/images/"+yol));
            return yol;
        }
        
        [HttpPost]
        public ActionResult Index(string id ,string pass)
        {
            var deger = db.Logins.Where(x => x.Kullanici == id && x.Sifre == pass).FirstOrDefault();
            if (deger != null)
            {
                AddCookie("user", deger.Kullanici);
                Response.Redirect("Yonetim");
            }
            else
            {
                Response.Redirect("/");
            }
            return View();
        }
        [UserAuthorize]
        public ActionResult Yonetim()
        {
            return View(db.Urunlers.ToList());
        }
        [UserAuthorize]
        [HttpPost]
        public ActionResult Create(Urunler urun,HttpPostedFileBase resim, IEnumerable<HttpPostedFileBase> resimlerrr)
        {
            string yolunyolu = ResimKaydet(resim);
            urun.ResimYol = "/Content/images/" + yolunyolu;
            Random rdm = new Random();
            urun.Resimid = rdm.Next();
            Resimler rsm = new Resimler();
            foreach(var item in resimlerrr)
            {
                string cyoll = ResimKaydet(item);
                rsm.Resimyolu = "/Content/images/" + cyoll;
                rsm.Resimid = urun.Resimid;
                db.Resimlers.Add(rsm);
                db.SaveChanges();



            }

            db.Urunlers.Add(urun);
            db.SaveChanges();
            return View();
        }
        [UserAuthorize]
        public ActionResult Create()
        {
         
            return View();
        }
        [UserAuthorize]
        public ActionResult Edit(int id)
        {
            var gelen = db.Urunlers.Where(x => x.id == id).FirstOrDefault(); 
            return View(gelen);
        }
        [UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Urunler urun,HttpPostedFileBase resim, IEnumerable<HttpPostedFileBase> resimlerrr)
        {
            string yolunyolu = ResimKaydet(resim);
            urun.ResimYol = "/Content/images/" + yolunyolu;
            Random rdm = new Random();
            urun.Resimid = rdm.Next();
            Resimler rsm = new Resimler();
            foreach (var item in resimlerrr)
            {
                string cyoll = ResimKaydet(item);
                rsm.Resimyolu = "/Content/images/" + cyoll;
                rsm.Resimid = urun.Resimid;
                db.Resimlers.Add(rsm);
                db.SaveChanges();



            }
            db.Entry(urun).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return View();
        }
        [UserAuthorize]
        public ActionResult Delete(int id=0)
        {
          
            return View(db.Urunlers.Find(id));
        }
        [UserAuthorize]
        [HttpPost,ActionName("Delete")]
        public ActionResult delete_conf(int id)
        {
            Urunler urun = db.Urunlers.Find(id);
            db.Urunlers.Remove(urun);
            db.SaveChanges();
            return Redirect("Yonetim");
            
        }
        [UserAuthorize]
        public ActionResult Details(int id=0)
        {

            return View(db.Urunlers.Find(id));
        }

        public void AddCookie(string cookieName, string cookieValue)
        {
            // Cookie Ekleme
            //cookieName : Cookie adı
            //cookieValue : Cookie değeri
            HttpCookie cookie = new HttpCookie(cookieName, cookieValue);
            cookie.Expires = DateTime.Now.AddYears(1); // Süre(1 yıl)
            HttpContext.Response.Cookies.Add(cookie);
        }
        public void DeleteCookie(string userCookieName)
        {
            //Cookie Silme
            HttpCookie myCookie = new HttpCookie(userCookieName);
            myCookie.Expires = DateTime.Now.AddYears(-1);// Süreyi  1 sene azaltıyoruz
            Response.Cookies.Add(myCookie);
        }
        public string GetCookie(string cookieName)
        {
            // Cookie adıyla değeri çekme
            string cookie = HttpContext.Request.Cookies[cookieName].Value;
            return cookie;
        }


    }
}