using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCrudProject.Data.Entities;

namespace MvcCrudProject.Business.Interfaces
{
    public interface ILoginManager
    {
        List<Login> HepsiniGetir();
        void Kaydet(Login login);
        void Sil(int id);

    }
}
