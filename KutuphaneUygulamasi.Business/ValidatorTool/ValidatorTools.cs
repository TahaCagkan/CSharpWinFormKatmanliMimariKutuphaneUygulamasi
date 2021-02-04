using FluentValidation;
using KutuphaneUygulamasi.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUygulamasi.Business.ValidatorTool
{
    public class ValidatorTools
    {
        public bool Validators(IValidator validator,IEntity entity)
        {
            bool sonuc = true;
            //tipini bilmediğim bir validator ile ,tipini bilmediğim bir entity ile  Validat edildi.
            var dogrulamaKontrol = validator.Validate(entity);
            if(!dogrulamaKontrol.IsValid)
            {
                string mesaj = null;
                foreach (var error in dogrulamaKontrol.Errors)
                {
                    mesaj += error.ErrorMessage + "\n";
                }
                MessageBox.Show(mesaj);
                sonuc = false;
                
            }
            return sonuc;
        }
    }
}
