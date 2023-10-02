using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db = new Context();
        public ActionResult Index()
        {
            var blog = db.Blogs.Where(x => x.Status == true).OrderByDescending(x => x.Id).ToList();
            return View(blog);
        }
        public PartialViewResult Sonbloglar()
        {
            var sonblog = db.Blogs.Where(x => x.Status == true).OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(sonblog);
        }
        public ActionResult Detay(int id)
        {
            var bul = db.Blogs.FirstOrDefault(x=>x.Id == id);
            ViewBag.Resim = bul.ImageUrl;
            ViewBag.name = bul.Name;
            ViewBag.tarih = bul.Date.ToShortDateString();
            ViewBag.metin = bul.Content;
            ViewBag.id = bul.Id;
            return View("Detay", bul);
        }
        public PartialViewResult Yorumlar(int id)
        {
            
            
            var yorum = db.Comments.Where(x=>x.BlogId == id && x.Status == true ).ToList();
            return PartialView(yorum);
        }
        [HttpPost]
        public ActionResult Yorumyap(Comment p)
        {
            p.Date = DateTime.Now;
            p.Status = false;
            db.Comments.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Blog");
        }

        public PartialViewResult sonyorumlar()
        {
            var sonyorum = db.Comments.Where(x => x.Status == true && x.Blog.Status == true).Take(3).OrderByDescending(x=>x.Id).ToList();
            return PartialView(sonyorum);
        }
    }
}