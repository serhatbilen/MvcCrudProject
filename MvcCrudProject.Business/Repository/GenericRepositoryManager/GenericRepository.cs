using MvcCrudProject.Business.Repository.GenericRepositoryInterface;
using MvcCrudProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProject.Business.Repository.GenericRepositoryManager
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        CrudDbContext db;
        DbSet<T> dbSet;
        public GenericRepository()
        {
            db = new CrudDbContext();
            this.dbSet = db.Set<T>();
        }

        public List<T> HepsiniGetir()
        {
            return dbSet.ToList();
        }

        public T IdyeGoreGetir(int id)
        {
            return dbSet.Find(id);
        }

        public void Ekle(T entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
        }
        public void Guncelle(T entity)
        {
            dbSet.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Sil(int id)
        {
            var silinecek = dbSet.Find(id);
            dbSet.Remove(silinecek);
            db.SaveChanges();
        }
    }
}
