using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models.Entity;

namespace WebApplication5.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        DbKisiBilgiEntities5 db = new DbKisiBilgiEntities5();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Musteriler.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniKullanici()
        {
            List<SelectListItem> degerler = (from i in db.Tbl_Sehirler.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.SehirAd,
                                                 Value = i.SehirID.ToString()
                                             }).ToList();

            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public ActionResult YeniKullanici(Tbl_Musteriler p1)
        {
            var ktg = db.Tbl_Sehirler.Where(m => m.SehirID == p1.Tbl_Sehirler.SehirID).FirstOrDefault();
            p1.Tbl_Sehirler = ktg;
            db.Tbl_Musteriler.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SIL(int id)
        {
            var kullanici = db.Tbl_Musteriler.Find(id);
            db.Tbl_Musteriler.Remove(kullanici);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Oranlar()
        {
            var degerler = db.Tbl_Musteriler.ToList();
            return View(degerler);
        }

    }
}