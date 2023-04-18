using Business.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class UlkeValidator:AbstractValidator<Ulke>
    {
        public UlkeValidator()
        {
            RuleFor(r => r.Ulkeadi).NotEmpty().WithMessage("Grub Adı boş olamaz !");
            RuleFor(r => r.Ulkeadi).MinimumLength(3).WithMessage("Grub Adı minimum 3 karakter içermelidir");
            RuleFor(r => r.Ulkeadi).MaximumLength(25).WithMessage("Grub Adı maximum 25 karakter içermelidir");
        }
    }
}
