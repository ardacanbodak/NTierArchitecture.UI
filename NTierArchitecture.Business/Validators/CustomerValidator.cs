using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerName)
                .NotEmpty()
                .WithMessage("İsim adı alanı boş bırakılamaz!!");
            RuleFor(c => c.Country)
                .NotEmpty()
                .WithMessage("Ülke adı alanı boş bırakılamaz!!");
            RuleFor(c => c.City)
                .NotEmpty()
                .WithMessage("Şehir adı alanı boş bırakılamaz!!");
            RuleFor(c => c.Phone)
                .NotEmpty()
                .WithMessage(" Telefon alanı boş bırakılamaz!!");
        }
    }
}
