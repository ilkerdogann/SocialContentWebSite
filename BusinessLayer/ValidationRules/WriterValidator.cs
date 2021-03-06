using EntityLayer.Concrete;
using FluentValidation;
using System.Linq;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen Yazar Adını Boş Geçmeyin!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Lütfen Soyadınızı Boş Geçmeyin!");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapın!");
            RuleFor(x => x.WriterSurname).MaximumLength(40).WithMessage("Lütfen 40 Karakterden Fazla Değer Girişi Yapmayın!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Lütfen Hakkında Kısmını Boş Geçmeyin!").Must(x => x.Contains('A')).WithMessage("Hakkında bilgisinde A karakteri olmak zorundadır!");
        }
    }
}
