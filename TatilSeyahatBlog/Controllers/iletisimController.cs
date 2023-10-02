using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        Context db = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact p)
        {
            p.Date = DateTime.Now;
            db.Contacts.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "AnaSayfa");
        }
    }
}