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
    public class BarkodMap : EntityTypeConfiguration<Barkod>
    {
        public BarkodMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Barkodu).HasMaxLength(12);
            this.Property(c => c.Salon).HasMaxLength(30);
            this.Property(c => c.Dolap).HasMaxLength(30);
            this.Property(c => c.Raf).HasMaxLength(30);
            this.Property(c => c.Sira).HasMaxLength(10);
            this.Property(c => c.Aciklama).HasMaxLength(200);


            this.ToTable("Barkod");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Kondisyon).HasColumnName("Kondisyon");
            this.Property(c => c.KitapId).HasColumnName("KitapId");
            this.Property(c => c.Barkodu).HasColumnName("Barkodu");
            this.Property(c => c.Salon).HasColumnName("Salon");
            this.Property(c => c.Dolap).HasColumnName("Dolap");
            this.Property(c => c.Raf).HasColumnName("Raf");
            this.Property(c => c.Sira).HasColumnName("Sira");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");

        }
    }
}
