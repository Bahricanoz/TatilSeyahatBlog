using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class AdminAboutController : Controller
    {
        // GET: AdminAbout
        Context db = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            var bul = db.Abouts.FirstOrDefault(x => x.Id == 1);
            return View("Index",bul);
        }
        [HttpPost]
        public ActionResult Index(About p)
        {
            var deger = db.Abouts.FirstOrDefault(x => x.Id == 1);
            deger.Content = p.Content;
            deger.Image = p.Image;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}