using FluentValidation;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Business.Validators
{
    public class UyeValidator: AbstractValidator<Uye>
    {
        public UyeValidator()
        {
            RuleFor(x => x.SinifId).NotEmpty().WithMessage("Sınıf seçimi yapılmadı");
        }
    }
}
