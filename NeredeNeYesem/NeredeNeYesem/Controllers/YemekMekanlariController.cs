using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeredeNeYesem.Models.Siniflar;



namespace NeredeNeYesem.Controllers
{
    [AllowAnonymous]
    public class YemekMekanlariController : Controller
    {
        Context c = new Context();
        MekanYorum my = new MekanYorum();
        public ActionResult Index()
        {
            my.Deger1 = c.YemekMekanlaris.ToList();
            my.Deger3 = c.YemekMekanlaris.OrderByDescending(x => x.ID).Take(5).ToList();
            return View(my);
        }
        public ActionResult MekanDetay(int id)
        {
            my.Deger1 = c.YemekMekanlaris.Where(x => x.ID == id).ToList();
            return View(my);
        }
        [HttpPost]
        public ActionResult YorumListele(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            my.Deger2 = c.Yorumlars.Where(x => x.YemekMekanlariId == id).ToList();
            return Json(new { yorums = my.Deger2 }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult YorumYap2(Yorumlar y)
        {
            c.Configuration.ProxyCreationEnabled = false;
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return Json(new { success = true, yorum = y }, JsonRequestBehavior.AllowGet);
        }
    }
}