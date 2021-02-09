using MvcCrudProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProject.Business.Interfaces
{
    public interface ICalisanManager
    {
        List<Calisan> HepsiniGetir();
        Calisan IdyeGoreGetir(int id);
        void Kaydet(Calisan calisan);
        //void Ekle(Calisan calisan);
        //void Guncelle(Calisan calisan);
        void Sil(int id);
    }
}
