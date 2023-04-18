using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class İlceValidator:AbstractValidator<İlce>
    {
        public İlceValidator() 
        {
            RuleFor(r=>r.İlceAdi).NotEmpty().WithMessage("İlçe Adı boş olamaz !");
            RuleFor(r => r.İlceAdi).MinimumLength(3).WithMessage("İlçe Adı minimum 3 karakter içermelidir");
            RuleFor(r => r.İlceAdi).MaximumLength(25).WithMessage("İlçe Adı maximum 25 karakter içermelidir");
            RuleFor(r => r.Sehirsid).NotEmpty().WithMessage("Grub Seçiniz !");
           
        }
    }
}
