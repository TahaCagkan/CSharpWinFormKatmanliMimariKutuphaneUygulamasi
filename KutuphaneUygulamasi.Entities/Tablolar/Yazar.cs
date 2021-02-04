using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Entities
{
   public class Yazar: IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DogumYili { get; set; }
        public string DogumYeri { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Kitap> Kitaplar { get; set; }
    }
}
