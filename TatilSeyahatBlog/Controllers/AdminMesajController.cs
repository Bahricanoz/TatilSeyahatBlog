using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class AdminMesajController : Controller
    {
        // GET: AdminMesaj
        Context db = new Context();
        public ActionResult Index()
        {
            var mesaj = db.Contacts.OrderByDescending(x=>x.Id).ToList();
            return View(mesaj);
        }
        public ActionResult Sil(int id)
        {
            var sil = db.Contacts.Find(id);
            db.Contacts.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}