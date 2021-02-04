using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Entities
{
   public class Adres:IEntity
    {
        public int Id { get; set; }
        public int UyeId { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string Adresi { get; set; }
        public string Aciklama { get; set; }

        public virtual Uye Uye { get; set; }
    }
}
