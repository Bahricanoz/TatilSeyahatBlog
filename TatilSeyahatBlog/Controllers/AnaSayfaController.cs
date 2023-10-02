using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatBlog.Models.Entity;

namespace TatilSeyahatBlog.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context db = new Context();
        public ActionResult Index()
        {
            var bloggörsel = db.Blogs.OrderByDescending(x=>x.Id).Take(5).Where(x=>x.Status == true).ToList();
            return View(bloggörsel);
        }
        public PartialViewResult Top5()
        {
            var top5 = db.Blogs.Where(x => x.Status == true).Take(5).ToList();
            return PartialView(top5);
        }
        public PartialViewResult Top3()
        {
            var top3 = db.Blogs.OrderByDescending(x=>x.Id).Where(x => x.Status == true).Take(3).ToList();
            return PartialView(top3);
        }

        public PartialViewResult Son3()
        {
            var son = db.Blogs.OrderByDescending(x => x.Id).Where(x => x.Status == true).Take(3).ToList();
            return PartialView(son);
        }

        public PartialViewResult ilk3()
        {
            var ilk = db.Blogs.Where(x => x.Status == true).Take(3).ToList();
            return PartialView(ilk);
        }
    }
}