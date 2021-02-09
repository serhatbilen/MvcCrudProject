using MvcCrudProject.Business.Interfaces;
using MvcCrudProject.Data.Entities;
using MvcCrudProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProject.Business.Manager
{
    public class LoginManager : ILoginManager
    {
        public List<Login> HepsiniGetir()
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Login.ToList();
            }
        }

        public void Kaydet(Login login)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                if (login.Id == 0)
                {
                    db.Login.Add(login);
                }
                else
                {
                    var guncellenecekKullanici = db.Login.Find(login.Id);
                    if (guncellenecekKullanici == null)
                    {
                        return;
                    }
                    guncellenecekKullanici.KullaniciAdi = login.KullaniciAdi;
                    guncellenecekKullanici.Sifre = login.Sifre;
                }
                db.SaveChanges();
            }
        }

        public void Sil(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                var silinecekKullanici = db.Login.Find(id);
                db.Login.Remove(silinecekKullanici);
                db.SaveChanges();
            }
        }
    }
}
