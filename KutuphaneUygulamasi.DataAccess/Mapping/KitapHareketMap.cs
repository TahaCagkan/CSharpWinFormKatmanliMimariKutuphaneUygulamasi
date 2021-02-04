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
   public class KitapHareketMap: EntityTypeConfiguration<KitapHareket>
    {
        public KitapHareketMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("KitapHareketleri");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.KitapId).HasColumnName("KitapId");
            this.Property(c => c.UyeId).HasColumnName("UyeId");
            this.Property(c => c.BarkodId).HasColumnName("BarkodId");
            this.Property(c => c.VerilisTarihi).HasColumnName("VerilisTarihi");
            this.Property(c => c.VerilisSuresi).HasColumnName("VerilisSuresi");
            this.Property(c => c.TeslimTarihi).HasColumnName("TeslimTarihi");
            this.Property(c => c.DegerlendirmeKondisyon).HasColumnName("DegerlendirmeKondisyon");
            this.Property(c => c.DegerlendirmeZamanlama).HasColumnName("DegerlendirmeZamanlama");
            this.Property(c => c.DegerlendirmeYetkili).HasColumnName("DegerlendirmeYetkili");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");

        }
    }
}
