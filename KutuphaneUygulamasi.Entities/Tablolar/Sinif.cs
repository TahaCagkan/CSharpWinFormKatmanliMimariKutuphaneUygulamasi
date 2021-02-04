using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Entities
{
    public class Sinif: IEntity
    {
        public int Id { get; set; }
        public string OkulTuru { get; set; }
        public string Sinifi { get; set; }
        public string Sube { get; set; }
        public string Bolumu { get; set; }
        public string Aciklama { get; set; }
        //Bir sınıfın birden fazla öğrencisi olabilir
        public virtual ICollection<Uye> Uyeler { get; set; }
    }
}
