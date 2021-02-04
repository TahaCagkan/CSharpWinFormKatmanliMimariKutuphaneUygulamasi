using KutuphaneUygulamasi.DataAccess.Arayuzler;
using KutuphaneUygulamasi.DataAccess.Baglanti;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.DataAccess.VeriErisim
{
    public class AdresDal :EntityBaseRepository<Adres,KutuphaneUygulamasiContext>,IAdresDal
    {
       
    }
}
