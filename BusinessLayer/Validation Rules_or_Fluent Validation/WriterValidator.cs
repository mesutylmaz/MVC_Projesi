using EntityLayer.Concreate;    //Writer
using FluentValidation;     //AbstractValidator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation_Rules_or_Fluent_Validation
{
    public class WriterValidator : AbstractValidator<Writer>    //Yazar'a ait verilerin Validasyon Kontrolleri
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz!");
            RuleFor(x => x.WriterAbout).MinimumLength(3).WithMessage("Hakkında Kısmını Boş Geçemezsiniz!");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Yazar Soyadı İçin En Az 2 Karakter Girişi Yapmalısınız!");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar Soyadı İçin En Fazla 50 Karakter Girişi Yapabilirsiniz!");
        }
    }
}
