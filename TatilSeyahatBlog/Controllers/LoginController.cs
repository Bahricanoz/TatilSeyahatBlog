using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context db = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var bilgi = db.Admins.FirstOrDefault(x => x.Kullaniciadi == p.Kullaniciadi && x.Sifre == p.Sifre);
            if(bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.Kullaniciadi, false);
                Session["Kullanciadi"] = bilgi.Kullaniciadi.ToString();
                return RedirectToAction("Index", "AdminBlog");
            }
            return View("");
        }
    }
}