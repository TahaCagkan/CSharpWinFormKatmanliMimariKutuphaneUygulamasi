using KutuphaneUygulamasi.DataAccess.Arayuzler;
using KutuphaneUygulamasi.DataAccess.Baglanti;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.DataAccess.VeriErisim
{
    public class UyeDal:EntityBaseRepository<Uye, KutuphaneUygulamasiContext>,IUyeDal
    {
    }
}
