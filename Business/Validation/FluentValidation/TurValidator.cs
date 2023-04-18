using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class TurValidator:AbstractValidator<Tur>
    {
        public TurValidator()
        {

            RuleFor(r => r.Turadi).MinimumLength(3).WithMessage("Tur adı minimum 3 karakterli olamalı ! ");
            RuleFor(r => r.Turadi).MaximumLength(25).WithMessage("Tur adı maximum 25 karakter olmalı");
            RuleFor(r => r.Turadi).NotEmpty().WithMessage("Tur adı boş olamaz !");

            RuleFor(r=>r.Grubsid).NotEmpty().WithMessage("Grub Seçiniz !");

            RuleFor(r => r.Kod).MinimumLength(5).WithMessage("minimum 9 karakterli olamalı");
            RuleFor(r => r.Kod).MaximumLength(5).WithMessage("minimum 9 karakterli olamalı");
            RuleFor(r => r.Kod).NotEmpty().WithMessage("Kod alanı boş olamaz !");

            RuleFor(r => r.Unvan).MinimumLength(3).WithMessage("Unvan adı minimum 3 karakterli olamalı ! ");
            RuleFor(r => r.Unvan).MaximumLength(25).WithMessage("Unvan adı maximum 25 karakter olmalı");
            RuleFor(r => r.Unvan).NotEmpty().WithMessage("Unvan adı boş olamaz !");
        }
    }
}
