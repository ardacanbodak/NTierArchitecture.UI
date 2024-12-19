using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(s => s.CompanyName)
                .NotEmpty()
                .WithMessage("CompanyName alanı boş bırakılamaz!!")
                .MaximumLength(100)
                .WithMessage("CompanyName alanı 100 karakterden fazla olamaz!!");

            RuleFor(s => s.ContactTitle)
                .NotEmpty()
                .WithMessage("ContactTitle alanı boş bırakılamaz!!")
                .MaximumLength(50)
                .WithMessage("ContactTitle alanı 50 karakterden fazla olamaz!!");

            RuleFor(s => s.City)
                .NotEmpty()
                .WithMessage("City alanı boş bırakılamaz!!")
                .MaximumLength(50)
                .WithMessage("City alanı 50 karakterden fazla olamaz!!");

            RuleFor(s => s.Country)
                .NotEmpty()
                .WithMessage("Country alanı boş bırakılamaz!!")
                .MaximumLength(50)
                .WithMessage("Country alanı 50 karakterden fazla olamaz!!");

            RuleFor(s => s.Phone)
                .NotEmpty()
                .WithMessage("Phone alanı boş bırakılamaz!!")
                .MinimumLength(11).MaximumLength(11)
                .WithMessage("Phone alanı 11 karakter olmalıdır!!")
                .Matches("[0-9]")
                .WithMessage("Phone rakamlardan oluşmalıdır!!");
        }
    }
}
