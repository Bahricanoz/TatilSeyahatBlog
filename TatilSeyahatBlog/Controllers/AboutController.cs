using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context db = new Context();
        public ActionResult Index()
        {
            var about = db.Abouts.ToList();
            return View(about);
        }
    }
}