using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.DataAccess.Mapping
{
    public class KitapMap:EntityTypeConfiguration<Kitap>
    {
        public KitapMap()
        {
            //Sınırlama Düzenleme kısmı
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.KitapKodu).HasMaxLength(12);
            this.Property(c => c.ISBN).HasMaxLength(20);
            this.Property(c => c.Turu).HasMaxLength(30);
            this.Property(c => c.KitapAdi).HasMaxLength(50);
            this.Property(c => c.YayinEvi).HasMaxLength(50);
            this.Property(c => c.BasimYeri).HasMaxLength(30);
            this.Property(c => c.DemirbasNo).HasMaxLength(20);
            this.Property(c => c.Aciklama).HasMaxLength(300);

            //Tablo adları
            this.ToTable("Kitaplar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Durum).HasColumnName("Durum");
            this.Property(c => c.OduncVerilebilir).HasColumnName("OduncVerilebilir");
            ////this.Property(c => c.BarkodId).HasColumnName("BarkodId");
            this.Property(c => c.KitapKodu).HasColumnName("KitapKodu");
            this.Property(c => c.ISBN).HasColumnName("ISBN");
            this.Property(c => c.KitapAdi).HasColumnName("KitapAdi");
            this.Property(c => c.YazarId).HasColumnName("YazarId");
            this.Property(c => c.Turu).HasColumnName("Turu");
            this.Property(c => c.YayinEvi).HasColumnName("YayinEvi");
            this.Property(c => c.BasimYili).HasColumnName("BasimYili");
            this.Property(c => c.BasimSayisi).HasColumnName("BasimSayisi");
            this.Property(c => c.CiltSayisi).HasColumnName("CiltSayisi");
            this.Property(c => c.SayfaSayisi).HasColumnName("SayfaSayisi");
            this.Property(c => c.BasimYeri).HasColumnName("BasimYeri");
            this.Property(c => c.DemirbasNo).HasColumnName("DemirbasNo");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}
