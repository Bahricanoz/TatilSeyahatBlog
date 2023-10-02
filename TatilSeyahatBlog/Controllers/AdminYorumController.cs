using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class AdminYorumController : Controller
    {
        // GET: AdminYorum
        Context db = new Context();
        public ActionResult Index()
        {
            var yorum = db.Comments.OrderByDescending(x => x.Id).ToList();
            return View(yorum);
        }
        public ActionResult Aktif(int id)
        {
            var bul = db.Comments.FirstOrDefault(x => x.Id == id);
            bul.Status = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Pasif(int id)
        {
            var bul = db.Comments.FirstOrDefault(x => x.Id == id);
            bul.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}