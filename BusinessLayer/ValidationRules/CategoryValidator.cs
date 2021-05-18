using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Adını Boş Geçmeyin!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Lütfen Açıklamayı Boş Geçmeyin!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın!");
            RuleFor(x => x.CategoryName).MaximumLength(40).WithMessage("Lütfen 40 Karakterden Fazla Değer Girişi Yapmayın!");
        }
    }
}
