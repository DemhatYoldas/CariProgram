using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class GrubValidator:AbstractValidator<Grub>
    {
        public GrubValidator()
        {
            RuleFor(r => r.Grubadi).NotEmpty().WithMessage("Grub Adı boş olamaz !");
            RuleFor(r => r.Grubadi).MinimumLength(3).WithMessage("Grub Adı minimum 3 karakter içermelidir");
            RuleFor(r => r.Grubadi).MaximumLength(25).WithMessage("Grub Adı maximum 25 karakter içermelidir");
        }
    }
}
