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
    public class YazarMap: EntityTypeConfiguration<Yazar>
    {
        public YazarMap()
        {
            this.HasKey(c=> c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Adi).HasMaxLength(30);
            this.Property(c => c.Soyadi).HasMaxLength(30);
            this.Property(c => c.DogumYeri).HasMaxLength(30);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Yazarlar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Adi).HasColumnName("Adi");
            this.Property(c => c.Soyadi).HasColumnName("Soyadi");
            this.Property(c => c.DogumYili).HasColumnName("DogumYili");
            this.Property(c => c.DogumYeri).HasColumnName("DogumYeri");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}
