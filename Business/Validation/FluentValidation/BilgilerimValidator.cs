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

            RuleFor(r => r.Sabitno).MinimumLength(11).WithMessage("minimum 11 karakterli olamalı");
            RuleFor(r => r.Sabitno).MaximumLength(11).WithMessage("maximum 11 karakterli olamalı");
            RuleFor(r => r.Sabitno).NotEmpty().WithMessage("Sabitno  alanı boş olamaz !");

            RuleFor(r => r.Gsm).MinimumLength(11).WithMessage("minimum 11 karakterli olamalı");
            RuleFor(r => r.Gsm).MaximumLength(11).WithMessage("maximum 11 karakterli olamalı");
            RuleFor(r => r.Gsm).NotEmpty().WithMessage("Gsm  alanı boş olamaz !");

            RuleFor(r => r.Fax).MinimumLength(5).WithMessage(" 5 karakterli olamalı");
            RuleFor(r => r.Fax).MaximumLength(5).WithMessage("maximum 5 karakterli olamalı");
            RuleFor(r => r.Fax).NotEmpty().WithMessage("Fax  alanı boş olamaz !");

            RuleFor(r => r.Eposta).MinimumLength(3).WithMessage("Eposta alanı minimum 10 karakterli olamalı ! ");
            RuleFor(r => r.Eposta).MaximumLength(250).WithMessage("Eposta alanı maximum 250 karakter olmalı");
            RuleFor(r => r.Eposta).NotEmpty().WithMessage("Eposta alanı boş olamaz !");


            RuleFor(r => r.Url).MinimumLength(3).WithMessage("Url alanı minimum 10 karakterli olamalı ! ");
            RuleFor(r => r.Url).MaximumLength(250).WithMessage("Url alanı maximum 250 karakter olmalı");
            RuleFor(r => r.Url).NotEmpty().WithMessage("Url alanı boş olamaz !");

            RuleFor(r => r.Vergidaire).MinimumLength(3).WithMessage("Vergi daire alanı minimum 3 karakterli olamalı ! ");
            RuleFor(r => r.Vergidaire).MaximumLength(25).WithMessage("Vergi daire alanı maximum 25 karakter olmalı");
            RuleFor(r => r.Vergidaire).NotEmpty().WithMessage("Vergi daire alanı boş olamaz !");

            RuleFor(r => r.Vergino).MinimumLength(5).WithMessage(" 5 karakterli olamalı");
            RuleFor(r => r.Vergino).MaximumLength(5).WithMessage("maximum 5 karakterli olamalı");
            RuleFor(r => r.Vergino).NotEmpty().WithMessage("Vergi no  alanı boş olamaz !");


            RuleFor(r => r.AdSoyad).MinimumLength(3).WithMessage("Yetkili Adı Soyadı minimum 3 karakterli olamalı ! ");
            RuleFor(r => r.AdSoyad).MaximumLength(25).WithMessage("Yetkili Adı Soyadı maximum 25 karakter olmalı");
            RuleFor(r => r.AdSoyad).NotEmpty().WithMessage(" Yetkili Adı Soyadı boş olamaz !");


        }
    }
}
