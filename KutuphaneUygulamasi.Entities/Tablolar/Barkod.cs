using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Entities
{
   public class Barkod: IEntity
    {
        public int Id { get; set; }
        public int KitapId { get; set; }
        public string Barkodu { get; set; }
        public int Kondisyon { get; set; }
        public string Salon { get; set; }
        public string Dolap { get; set; }
        public string Raf { get; set; }
        public string Sira { get; set; }
        public string Aciklama { get; set; }
        public virtual Kitap Kitap { get; set; }
        public virtual ICollection<KitapHareket> KitapHareketleri { get; set; }
    }
}
