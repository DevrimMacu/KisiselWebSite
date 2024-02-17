using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSitem.Models.Siniflar;

namespace WebSitem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            
            var deger = c.Anasayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(AnaSayfa x)
        {
            var ag = c.Anasayfas.Find(x.id);
            return View("AnaSayfaGetir",ag);
        }
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ana = c.Anasayfas.Find(x.id);
            ana.isim = x.isim;
            ana.Profil = x.Profil;
            ana.Unvan = x.Unvan;
            ana.Aciklama = x.Aciklama;
            ana.iletisim = x.iletisim;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult IkonLar()
        {
            var deger = c.ikonlars.ToList();
            return View(deger);

        }
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(ikonlar a)
        {
            c.ikonlars.Add(a);
            c.SaveChanges();
            return RedirectToAction("IkonLar");
        }
        public ActionResult ikongetir(int id)
        {
            var icg = c.ikonlars.Find(id);
            return View("ikongetir", icg);
        }
        public ActionResult ikonGuncelle(ikonlar x)
        {
           var ig= c.ikonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("IkonLar");
        }
        public ActionResult ikonSil(int id)
        {
            var sil = c.ikonlars.Find(id);
            c.ikonlars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("IkonLar");
        }
    }
}