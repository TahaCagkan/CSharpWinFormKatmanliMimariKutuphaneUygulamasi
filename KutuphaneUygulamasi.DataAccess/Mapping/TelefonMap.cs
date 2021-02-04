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
   public class TelefonMap: EntityTypeConfiguration<Telefon>
    {
        public TelefonMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.AdiSoyadi).HasMaxLength(61);
            this.Property(c => c.Yakinlik).HasMaxLength(15);
            this.Property(c => c.Telefonu).HasMaxLength(15);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Telefonlar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.UyeId).HasColumnName("UyeId");
            this.Property(c => c.AdiSoyadi).HasColumnName("AdiSoyadi");
            this.Property(c => c.Yakinlik).HasColumnName("Yakinlik");
            this.Property(c => c.Telefonu).HasColumnName("Telefonu");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}
