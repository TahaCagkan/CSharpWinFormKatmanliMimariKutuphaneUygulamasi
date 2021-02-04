using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Entities
{
   public class Telefon: IEntity
    {
        public int Id { get; set; }
        public int UyeId { get; set; }
        public string AdiSoyadi { get; set; }
        public string Yakinlik { get; set; }
        public string Telefonu { get; set; }
        public string Aciklama { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
