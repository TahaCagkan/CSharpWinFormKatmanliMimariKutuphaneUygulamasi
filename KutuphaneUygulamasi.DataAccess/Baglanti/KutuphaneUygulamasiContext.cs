using KutuphaneUygulamasi.DataAccess.Mapping;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.DataAccess.Baglanti
{
    public class KutuphaneUygulamasiContext : DbContext
    {
   
        //Tablolarımıza DbSet generic kullarak property oluşturuldu.
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Barkod> Barkodlar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Telefon> Telefonlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<KitapHareket> KitapHareketleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Haritalama işlemleri
            modelBuilder.Configurations.Add(new KitapMap());
            modelBuilder.Configurations.Add(new BarkodMap());
            modelBuilder.Configurations.Add(new YazarMap());
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new SinifMap());
            modelBuilder.Configurations.Add(new TelefonMap());
            modelBuilder.Configurations.Add(new AdresMap());
            modelBuilder.Configurations.Add(new KitapHareketMap());
            modelBuilder.Configurations.Add(new TanimMap());

            //ilişkilerin Tanımlanması
            modelBuilder.Entity<Kitap>().HasRequired(c => c.Yazar).WithMany(c => c.Kitaplar).HasForeignKey(c => c.YazarId);
            //Kitap silindiğinde kitapa ait tüm barkodlar silinecektir.
            modelBuilder.Entity<Barkod>().HasRequired(c => c.Kitap).WithMany(c => c.Barkodlar).HasForeignKey(c => c.KitapId).WillCascadeOnDelete();
            modelBuilder.Entity<KitapHareket>().HasRequired(c => c.Kitap).WithMany(c => c.KitapHareketleri).HasForeignKey(c => c.KitapId);
            modelBuilder.Entity<KitapHareket>().HasRequired(c => c.Uye).WithMany(c => c.KitapHareketleri).HasForeignKey(c => c.UyeId);

            modelBuilder.Entity<Uye>().HasRequired(c => c.Sinif).WithMany(c => c.Uyeler).HasForeignKey(c => c.SinifId);
            modelBuilder.Entity<Telefon>().HasRequired(c => c.Uye).WithMany(c => c.Telefonlar).HasForeignKey(c => c.UyeId);
            modelBuilder.Entity<Adres>().HasRequired(c => c.Uye).WithMany(c => c.Adresler).HasForeignKey(c => c.UyeId);
            modelBuilder.Entity<KitapHareket>().HasRequired(x => x.Barkod).WithMany(x => x.KitapHareketleri).HasForeignKey(x => x.BarkodId).WillCascadeOnDelete(false);


        }
    }
}
