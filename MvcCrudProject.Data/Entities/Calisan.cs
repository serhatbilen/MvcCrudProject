using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCrudProject.Models.Entities
{
    public class Calisan : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }
        public int departmanId { get; set; }
        public virtual Departman departman { get; set; }
    }
}