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
    public class UyeMap: EntityTypeConfiguration<Uye>
    {
        public UyeMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.TcKimlikNo).HasMaxLength(11);
            this.Property(c => c.Barkod).HasMaxLength(12);
            this.Property(c => c.Adi).HasMaxLength(30);
            this.Property(c => c.Soyadi).HasMaxLength(30);
            this.Property(c => c.YabanciDil).HasMaxLength(15);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Uyeler");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Durum).HasColumnName("Durum");
            this.Property(c => c.TcKimlikNo).HasColumnName("TcKimlikNo");
            this.Property(c => c.OkulNo).HasColumnName("OkulNo");
            this.Property(c => c.Barkod).HasColumnName("Barkod");
            this.Property(c => c.Adi).HasColumnName("Adi");
            this.Property(c => c.Soyadi).HasColumnName("Soyadi");
            this.Property(c => c.SinifId).HasColumnName("SinifId");
            this.Property(c => c.YabanciDil).HasColumnName("YabanciDil");
            this.Property(c => c.KayitTarih).HasColumnName("KayitTarih");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}
