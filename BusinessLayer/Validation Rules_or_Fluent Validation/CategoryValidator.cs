using EntityLayer.Concreate;    //Category
using FluentValidation;     //AbstractValidator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation_Rules_or_Fluent_Validation
{
    public class CategoryValidator : AbstractValidator<Category>    //Categori'ye ait verilerin Validasyon Kontrolleri
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklaması Girmeniz Gerekmektedir!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı İçin Lütfen En Az 3 Karakter Girişi Yapınız!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori Adı İçin En Fazla 20 Karakter Girişi Yapabilirsiniz!");
        }
    }
}
