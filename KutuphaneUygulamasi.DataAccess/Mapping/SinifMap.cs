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
    public class SinifMap: EntityTypeConfiguration<Sinif>
    {
        public SinifMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.OkulTuru).HasMaxLength(30);
            this.Property(c => c.Sinifi).HasMaxLength(10);
            this.Property(c => c.Sube).HasMaxLength(10);
            this.Property(c => c.Bolumu).HasMaxLength(30);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Siniflar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.OkulTuru).HasColumnName("OkulTuru");
            this.Property(c => c.Sinifi).HasColumnName("Sinifi");
            this.Property(c => c.Sube).HasColumnName("Sube");
            this.Property(c=> c.Bolumu).HasColumnName("Bolumu");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}
