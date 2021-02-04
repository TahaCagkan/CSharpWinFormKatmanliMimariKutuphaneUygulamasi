using FluentValidation;
using KutuphaneUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Business.Validators
{
    public class BarkodValidator: AbstractValidator<Barkod>
    {
        public BarkodValidator()
        {
            RuleFor(x => x.Barkodu).NotEmpty().WithMessage("Barkodu alanı boş geçilemez.");
        }
    }
}
