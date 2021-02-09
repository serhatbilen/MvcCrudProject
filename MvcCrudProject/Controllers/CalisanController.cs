using MvcCrudProject.Business.Manager;
using MvcCrudProject.Business.Repository.GenericRepositoryManager;
using MvcCrudProject.Models.Context;
using MvcCrudProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrudProject.Controllers
{
    public class CalisanController : Controller
    {
        GenericRepository<Calisan> repo = new GenericRepository<Calisan>();
        CrudDbContext db = new CrudDbContext();
        // GET: Calisan
        public ActionResult Index()
        {
            List<Calisan> calis = repo.HepsiniGetir();
            return View(db.Calisan.ToList());
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View("Ekle");
        }
        [HttpPost]
        public ActionResult Ekle(Calisan calisan)
        {
            repo.Ekle(calisan);
            return RedirectToAction("Index", "Calisan");
        }
        public ActionResult Guncelle(int id)
        {
            var model = db.Calisan.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle", model);
        }
        [HttpPost]
        public ActionResult Guncelle(Calisan calisan)
        {
            repo.Guncelle(calisan);
            return RedirectToAction("Index", "Calisan");
        }

        public ActionResult Sil(int id)
        {
            repo.Sil(id);
            return RedirectToAction("Index");

        }
    }
}