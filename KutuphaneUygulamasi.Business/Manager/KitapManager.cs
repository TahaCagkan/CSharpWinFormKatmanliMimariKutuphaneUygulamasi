using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.Business.Validators;
using KutuphaneUygulamasi.DataAccess.Arayuzler;
using KutuphaneUygulamasi.DataAccess.VeriErisim;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Business.Manager
{
    public class KitapManager : ManagerRepository<Kitap, KitapDal, KitapValidator>, IKitapService
    {
        //// Dependency Injection = dışardan aldığımız parametreyi içerde kullanmak için oluşturulan örnek
        //private IKitapDal _kitapDal;

        //public KitapManager(IKitapDal kitapDal)
        //{
        //    _kitapDal = kitapDal;
        //}

        //Getir içerisindek i Id ye göre çağır veriyi döndür.
        public Kitap IdDegergineGoreGetir(int id)
        {
            return this.Getir(x => x.Id == id);
        }

        //public override Kitap Sil(Kitap entity)
        //{
        //    return base.Sil(entity);
        //    IKitapHareketService kitapHareketService = new KitapHareketManager();
        //    kitapHareketService.Sil(x => x.KitapId == entity.Id);
        //}
    }
}
