using KutuphaneUygulamasi.DataAccess.Arayuzler;
using KutuphaneUygulamasi.DataAccess.Baglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.DataAccess.VeriErisim
{
    public class EntityBaseRepository<TEntity,TContext> : IEntityRepository<TEntity>
    where TEntity:class,IEntity,new()
     where TContext:DbContext,new()
    {
        private TContext _context;

        public TEntity EkleveyaGuncelle(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
            return entity;
            
        }

        public TEntity Ekle(TEntity entity)
        {
            //_context kitap kaydı girişi yap (bana gelen parametre) = eklenecek olan kayıt 
            _context.Entry<TEntity>(entity).State = EntityState.Added;
            return entity;
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filtre)
        {
            //tek bir kayıt dönücek
            return _context.Set<TEntity>().SingleOrDefault(filtre);
        }

        public TEntity Guncelle(TEntity entity)
        {
            //_context TEntity kaydı girişi yap (bana gelen parametre) = güncellencek olan kayıt 
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return entity;
        }

        public void Kaydet()
        {
            _context.SaveChanges();
        }
        public DbContext OrnekOlustur(bool yeni = false)
        {
            //OrnekOlustur Methodunda true verirsem yeni bir örnek oluştur,değil ise eski context aynen göndericek
            return yeni == true
                ? _context = new TContext()
                : _context;
        }
        public void OrnegeBagla(DbContext context)
        {
            //globalde oluşutulan _context,parametre olarak gelen context bağla
            _context =(TContext)context;
        }
        public List<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null)
        {
            //Filtre null ise tüm TEntity listeyi döndür,değil ise filtre arama parametresine göre listeyi döndür
            return filtre == null
               ? _context.Set<TEntity>().ToList()
               : _context.Set<TEntity>().Where(filtre).ToList();
                
        }

      

        public TEntity Sil(TEntity entity)
        {
            //_context TEntity kaydı girişi yap (bana gelen parametre) = silincek olan kayıt 
            _context.Entry<TEntity>(entity).State = EntityState.Deleted;
            return entity;
        }

        public void Sil(Expression<Func<TEntity, bool>> filtre)
        {
            //birden fazla kayıt silemk için
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filtre));
        }
        public BindingList<TEntity> BaglantiNesnesi(Expression<Func<TEntity, bool>> filtre = null)
        {
            if(filtre ==null)
            {
                _context.Set<TEntity>().Load();
            }
            else
            {
                _context.Set<TEntity>().Where(filtre).Load();
            }           
            return _context.Set<TEntity>().Local.ToBindingList();
        }
    }
}
