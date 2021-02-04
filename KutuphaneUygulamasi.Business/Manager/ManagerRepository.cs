using FluentValidation;
using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.Business.ValidatorTool;
using KutuphaneUygulamasi.DataAccess.Arayuzler;
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
    public class ManagerRepository<TEntity,TDal,TValidator>:IServiceRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TDal:class,IEntityRepository<TEntity>,new()
        where TValidator:IValidator,new()
    {
        TDal _dal = new TDal();
        ValidatorTools dogrulamaAraci = new ValidatorTools();
        TValidator dogrulama = new TValidator();
        public TEntity EkleveyaGuncelle(TEntity entity)
        {
            //validator olarak dogrulama,entity olarak entity degiskeni verildi
            if (dogrulamaAraci.Validators(dogrulama,entity))
            {
                //dogrulamaAraci işlemi doğrulama yapıldı ise ekleme yapılıyor
                return _dal.EkleveyaGuncelle(entity);
            }
            else
            {
                //doğrulanmadı ise null
                return null;
            }
        }


        public TEntity Ekle(TEntity entity)
        {
            //validator olarak dogrulama,entity olarak entity degiskeni verildi
            if (dogrulamaAraci.Validators(dogrulama, entity))
            {
                return _dal.Ekle(entity);
            }
            else
            {
                return null;
            }
         }

        public TEntity Getir(Expression<Func<TEntity, bool>> filtre)
        {
            return _dal.Getir(filtre);
        }

        public TEntity Guncelle(TEntity entity)
        {
            //validator olarak dogrulama,entity olarak entity degiskeni verildi
            if (dogrulamaAraci.Validators(dogrulama, entity))
            {
                return _dal.Guncelle(entity);
            }
            else
            {
                return null;
            }
        }

        public void Kaydet()
        {
            _dal.Kaydet();
        }
        public BindingList<TEntity> BaglantiNesnesi(Expression<Func<TEntity, bool>> filtre = null)
        {
            return _dal.BaglantiNesnesi(filtre);
        }
        public List<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null)
        {
            return _dal.Listele(filtre);
        }

        public DbContext OrnekOlustur(bool yeni = false)
        {
            return _dal.OrnekOlustur(yeni);
        }
        public void OrnegeBagla(DbContext context)
        {
            _dal.OrnegeBagla(context);
        }
        //public virtual TEntity Sil(TEntity entity)
        public  TEntity Sil(TEntity entity)
        {
            //Kitapla birlikte kitabın tüm hareketlerinide silmek istersem, bunun için yapıldı.
            //IKitapHareketDal kitapHareketDal = new KitapHareketDal();
            //kitapHareketDal.Sil(x => x.KitapId == entity.Id);
            //return _kitapDal.Sil(entity);
            //validator olarak dogrulama,entity olarak entity degiskeni verildi
            if (dogrulamaAraci.Validators(dogrulama, entity))
            {
                return _dal.Sil(entity);
            }
            else
            {
                return null;
            }
        }

        public void Sil(Expression<Func<TEntity, bool>> filtre)
        {
            _dal.Sil(filtre);
        }

    
    }
}

