using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeredeNeYesem.Models.Siniflar;
namespace NeredeNeYesem.Controllers
{
    [AllowAnonymous]
    public class IletisimController : Controller
    {
        // GET: Iletisim

        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MesajGonder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MesajGonder(Iletisim i)
        {
            c.Iletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
