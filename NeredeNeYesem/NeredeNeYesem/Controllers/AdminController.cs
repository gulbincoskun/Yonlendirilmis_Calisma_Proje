using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeredeNeYesem.Models.Siniflar;
namespace NeredeNeYesem.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.YemekMekanlaris.ToList();
            return View(degerler);
        }

        [Authorize(Roles = "G")]
        [HttpGet]
        public ActionResult YeniMekan()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult YeniMekan(YemekMekanlari p)
        {
            c.YemekMekanlaris.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MekanSil(int id)
        {
            var m = c.YemekMekanlaris.Find(id);
            c.YemekMekanlaris.Remove(m);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MekanGetir(int id)
        {
            var mn = c.YemekMekanlaris.Find(id);
            return View("MekanGetir", mn);
        }
        public ActionResult MekanGuncelle(YemekMekanlari m)
        {
            var mkn = c.YemekMekanlaris.Find(m.ID);
            mkn.Baslik = m.Baslik;
            mkn.FotoUrl = m.FotoUrl;
            mkn.Aciklama = m.Aciklama;
            mkn.Tarih = m.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var m = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(m);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yrm = c.Yorumlars.Find(id);
            return View("YorumGetir", yrm);
        }
        public ActionResult YorumGuncelle(Yorumlar m)
        {
            var yrm = c.Yorumlars.Find(m.ID);
            yrm.KullaniciAdi = m.KullaniciAdi;
            yrm.Mail = m.Mail;
            yrm.Yorum = m.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult MesajListesi()
        {
            var mesajlar = c.Iletisims.ToList();
            return View(mesajlar);
        }
        public ActionResult MesajSil(int id)
        {
            var mj = c.Iletisims.Find(id);
            c.Iletisims.Remove(mj);
            c.SaveChanges();
            return RedirectToAction("MesajListesi");
        }

        public ActionResult Hakkimizda()
        {
            var hakkimizda = c.Hakkimizdas.ToList();
            return View(hakkimizda);
        }

        public ActionResult HakkimizdaGetir(int id)
        {
            var hkm = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", hkm);
        }
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var hkm = c.Hakkimizdas.Find(h.ID);
            hkm.FotoUrl = h.FotoUrl;
            hkm.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }

    }
}