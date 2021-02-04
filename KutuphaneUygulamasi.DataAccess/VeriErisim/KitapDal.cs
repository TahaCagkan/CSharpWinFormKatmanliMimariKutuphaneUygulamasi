using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneUygulamasi.DataAccess.Arayuzler;
using KutuphaneUygulamasi.DataAccess.Baglanti;
using KutuphaneUygulamasi.Entities;
namespace KutuphaneUygulamasi.DataAccess.VeriErisim
{
    public  class KitapDal : EntityBaseRepository<Kitap, KutuphaneUygulamasiContext>,IKitapDal
    {
              
    }
}
