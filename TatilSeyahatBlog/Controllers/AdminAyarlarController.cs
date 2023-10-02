using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class AdminAyarlarController : Controller
    {
        // GET: AdminAyarlar
        Context db = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            var bul = db.Admins.Find(1);
            return View("Index",bul);
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var deger = db.Admins.FirstOrDefault(x => x.Id == 1);
            deger.Sifre = p.Sifre;
            deger.Kullaniciadi = p.Kullaniciadi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}