using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class AdminBlogController : Controller
    {
        // GET: AdminBlog
        Context db = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var blog = db.Blogs.ToList();
            return View(blog);
        }
        public ActionResult Aktif(int id)
        {
            var bul = db.Blogs.FirstOrDefault(x => x.Id == id);
            bul.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Pasif(int id)
        {
            var bul = db.Blogs.Find(id);
            bul.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Blog p)
        {
            p.Status = true;
            p.Date = DateTime.Now;
            db.Blogs.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var bul = db.Blogs.Find(id);
            return View("Guncelle", bul);
        }
        [HttpPost]
        public ActionResult Guncelle(Blog p)
        {
            var deger = db.Blogs.FirstOrDefault(x => x.Id == p.Id);
            deger.Name = p.Name;
            deger.Content = p.Content;
            deger.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}