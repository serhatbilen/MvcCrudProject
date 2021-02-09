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
    public class DepartmanController : Controller
    {
        CrudDbContext db = new CrudDbContext();
        GenericRepository<Departman> repo = new GenericRepository<Departman>();
        // GET: Departman
        public ActionResult Index()
        {
            List<Departman> dep = repo.HepsiniGetir();
            return View(dep);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View("Ekle");
        }
        [HttpPost]
        public ActionResult Ekle(Departman departman) 
        {
            repo.Ekle(departman);
            return RedirectToAction("Index", "Departman");
        }
        [HttpPost]
        public ActionResult Guncelle (Departman departman)
        {
            repo.Guncelle(departman);
            return RedirectToAction("Index", "Departman");
        }
        public ActionResult Guncelle (int id)
        {
            var model = db.Departman.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View("Guncelle",model);
        }
        public ActionResult Sil (int id)
        {
            repo.Sil(id);
            return RedirectToAction("Index");
        }
    }
}