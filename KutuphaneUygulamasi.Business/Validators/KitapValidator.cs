using FluentValidation;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Business.Validators
{
    public class KitapValidator:AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            RuleFor(x => x.KitapKodu).NotEmpty().WithMessage("Kitap kodu alanı boş geçilemez.");
            RuleFor(x => x.KitapAdi).NotEmpty().WithMessage("Kitap Adı alanı boş geçilemez.");

        }
    }
}
