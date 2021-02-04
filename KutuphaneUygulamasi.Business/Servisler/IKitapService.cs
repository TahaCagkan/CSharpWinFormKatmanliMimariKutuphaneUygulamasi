using KutuphaneUygulamasi.DataAccess.Arayuzler;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Business.Servisler
{
    public interface IKitapService:IServiceRepository<Kitap>
    {
        Kitap IdDegergineGoreGetir(int id);
    }
}
