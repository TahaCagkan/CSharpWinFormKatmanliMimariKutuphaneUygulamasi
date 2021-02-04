using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Entities
{
    public class Kitap: IEntity
    {
        public int Id { get; set; }
        public bool Durum { get; set; }
        public bool OduncVerilebilir { get; set; }
        public string KitapKodu { get; set; }
        public string ISBN { get; set; }
        public string KitapAdi { get; set; }
        public int YazarId { get; set; }
        public string Turu { get; set; }
        public string YayinEvi { get; set; }
        public int BasimYili { get; set; }
        public int BasimSayisi { get; set; }
        public string CiltSayisi { get; set; }
        public int SayfaSayisi { get; set; }
        public string BasimYeri { get; set; }
        public string DemirbasNo { get; set; }
        public string Aciklama { get; set; }

        public virtual Yazar Yazar { get; set; }
       // public virtual Tanim TurTanim { get; set; }
        public virtual ICollection<Barkod> Barkodlar { get; set; }
        public virtual ICollection<KitapHareket> KitapHareketleri { get; set; }
    }
}
