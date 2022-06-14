using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeredeNeYesem.Models.Siniflar;

namespace NeredeNeYesem.Controllers
{
    [AllowAnonymous]
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}