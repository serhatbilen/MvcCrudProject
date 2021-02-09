using MvcCrudProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcCrudProject.Data.Entities
{
    public class Login:BaseEntity
    {
        [Required(ErrorMessage = "Kullanıcı Adı Girilmelidir!!")]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Şifre Girilmelidir!!")]
        public string Sifre { get; set; }
    }
}
