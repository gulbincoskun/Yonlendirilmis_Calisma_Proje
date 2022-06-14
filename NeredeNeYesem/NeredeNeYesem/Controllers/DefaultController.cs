using System.Linq;
using System.Web.Mvc;
using NeredeNeYesem.Models.Siniflar;
namespace NeredeNeYesem.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default

        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.YemekMekanlaris.ToList();
            return View(degerler);
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public PartialViewResult Partial()
        {
            var deger = c.YemekMekanlaris.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.YemekMekanlaris.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
    }
}