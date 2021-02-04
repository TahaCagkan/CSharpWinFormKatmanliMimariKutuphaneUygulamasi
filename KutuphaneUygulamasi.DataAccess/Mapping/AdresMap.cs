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
   public class AdresMap: EntityTypeConfiguration<Adres>
   {
        public AdresMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Il).HasMaxLength(30);
            this.Property(c => c.Ilce).HasMaxLength(30);
            this.Property(c => c.Semt).HasMaxLength(30);
            this.Property(c => c.Adresi).HasMaxLength(100);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Adresler");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.UyeId).HasColumnName("UyeId");
            this.Property(c => c.Il).HasColumnName("Il");
            this.Property(c => c.Ilce).HasColumnName("Ilce");
            this.Property(c => c.Semt).HasColumnName("Semt");
            this.Property(c => c.Adresi).HasColumnName("Adresi");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
   }
}
