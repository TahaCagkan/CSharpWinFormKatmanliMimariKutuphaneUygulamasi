﻿using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Entities
{
    public class Tanim: IEntity
    {
        public int Id { get; set; }
        public string Tanimi { get; set; }
        public string Turu { get; set; }
        public string Aciklama { get; set; }
    }
}
