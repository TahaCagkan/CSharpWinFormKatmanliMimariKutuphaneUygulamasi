using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Business.Servisler
{
   public  interface IServiceRepository<TEntity> where TEntity: class,IEntity,new()
   {
        List<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null);
        TEntity Getir(Expression<Func<TEntity, bool>> filtre);
        TEntity Ekle(TEntity entity);
        TEntity Guncelle(TEntity entity);
        TEntity Sil(TEntity entity);
        TEntity EkleveyaGuncelle(TEntity entity);

        void Kaydet();
        BindingList<TEntity> BaglantiNesnesi(Expression<Func<TEntity, bool>> filtre = null);
        DbContext OrnekOlustur(bool yeni = false);

        void OrnegeBagla(DbContext context);
        void Sil(Expression<Func<TEntity, bool>> filtre);
    }
}
