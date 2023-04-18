using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class SehirValidator:AbstractValidator<Sehir>
    {
        public SehirValidator() 
        {
            RuleFor(r => r.Sehiradi).NotEmpty().WithMessage("Grub Adı boş olamaz !");
            RuleFor(r => r.Sehiradi).MinimumLength(3).WithMessage("Grub Adı minimum 3 karakter içermelidir");
            RuleFor(r => r.Sehiradi).MaximumLength(25).WithMessage("Grub Adı maximum 25 karakter içermelidir");

            RuleFor(r => r.Ulkesid).NotEmpty().WithMessage("Grub Seçiniz !");
        }
    }
}
