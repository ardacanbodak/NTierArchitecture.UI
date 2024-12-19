using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName)
                .NotEmpty()
                .WithMessage("ProductName alanı boş bırakılamaz!!")
                .MinimumLength(1)
                .WithMessage("ProductName 1 karakterden az olamaz!!");

            RuleFor(p => p.UnitPrice)
                .NotEmpty()
                .WithMessage("UnitPrice alanı boş bırakılamaz!!")
                .GreaterThan(0).WithMessage("UnitPrice sıfırdan büyük olmalıdır.");
                

            /*RuleFor(p => p.Discontinued)
                .NotEmpty()
                .WithMessage("Discontinued alanı boş bırakılamaz");*/

            RuleFor(p => p.UnitsInStock)
                .NotEmpty()
                .WithMessage("UnitsInStock alanı boş bırakılamaz!!")
                .GreaterThanOrEqualTo(0)
                .WithMessage("UnitsInStock negatif olamaz")
                .LessThanOrEqualTo(10000)
                .WithMessage("UnitsInStock 10000 den az veya eşit olmalıdır");
        }

    }
}
