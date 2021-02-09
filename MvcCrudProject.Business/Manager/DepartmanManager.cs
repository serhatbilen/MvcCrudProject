using MvcCrudProject.Business.Interfaces;
using MvcCrudProject.Models.Context;
using MvcCrudProject.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MvcCrudProject.Business.Manager
{
    public class DepartmanManager : IDepartmanManager
    {
        public List<Departman> HepsiniGetir()
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Departman.ToList();
            }
        }

        public Departman IdyeGoreGetir(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Departman.FirstOrDefault(x => x.Id == id);
            }
        }

        public void Kaydet(Departman departman)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                if (departman.Id == 0)
                {
                    db.Departman.Add(departman);
                }
                else
                {
                    var guncellenecekDepartman = db.Departman.Find(departman.Id);
                    if (guncellenecekDepartman == null)
                    {
                        return;
                    }
                    guncellenecekDepartman.Ad = departman.Ad;
                }
                db.SaveChanges();
            }

        }

        public void Sil(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                var silinecekDepartman = db.Departman.Find(id);
                db.Departman.Remove(silinecekDepartman);
                db.SaveChanges();
            }
        }
    }
}
