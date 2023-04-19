using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class BilgilerimValidator : AbstractValidator<Bilgilerim>
    {
        public BilgilerimValidator()
        {
            RuleFor(r => r.Grubsid).NotEmpty().WithMessage("Grub Seçiniz !");
            RuleFor(r => r.Tursid).NotEmpty().WithMessage("Grub Seçiniz !");

            RuleFor(r => r.TabelaAdi).MinimumLength(3).WithMessage("Tabela Adi adı minimum 3 karakterli olamalı ! ");
            RuleFor(r => r.TabelaAdi).MaximumLength(25).WithMessage("Tabela Adi adı maximum 25 karakter olmalı");
            RuleFor(r => r.TabelaAdi).NotEmpty().WithMessage("Tabela Adi adı boş olamaz !");

            RuleFor(r => r.Ulkesid).NotEmpty().WithMessage("Grub Seçiniz !");
            RuleFor(r => r.Sehirsid).NotEmpty().WithMessage("Grub Seçiniz !");
            RuleFor(r => r.İlcesid).NotEmpty().WithMessage("Grub Seçiniz !");

            RuleFor(r => r.Postakodu).MinimumLength(5).WithMessage("minimum 5 karakterli olamalı");
            RuleFor(r => r.Postakodu).MaximumLength(5).WithMessage("maximum 5 karakterli olamalı");
            RuleFor(r => r.Postakodu).NotEmpty().WithMessage("Posta Kod alanı boş olamaz !");

            RuleFor(r => r.Adres).MinimumLength(3).WithMessage("Adres alanı minimum 3 karakterli olamalı ! ");
            RuleFor(r => r.Adres).MaximumLength(250).WithMessage("Adres alanı maximum 250 karakter olmalı");
            RuleFor(r => r.Adres).NotEmpty().WithMessage("Adres alanı boş olamaz !");





        }
    }
}
