﻿using KutuphaneUygulamasi.Business.Servisler;
using KutuphaneUygulamasi.Business.Validators;
using KutuphaneUygulamasi.DataAccess.VeriErisim;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Business.Manager
{
    public class YazarManager:ManagerRepository<Yazar,YazarDal,YazarValidator>,IYazarService
    {

    }
}
