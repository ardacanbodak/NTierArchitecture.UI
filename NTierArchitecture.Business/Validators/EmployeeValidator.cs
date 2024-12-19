using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {


            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Ad alanı boş bırakılamaz!!");
            RuleFor(c => c.Surname)
               .NotEmpty()
               .WithMessage("CategoryName adı alanı boş bırakılamaz!!");
            RuleFor(c => c.Country)
               .NotEmpty()
               .WithMessage("CategoryName adı alanı boş bırakılamaz!!");
            RuleFor(c => c.City)
               .NotEmpty()
               .WithMessage("CategoryName adı alanı boş bırakılamaz!!");
            RuleFor(c => c.Phone)
               .NotEmpty()
               .WithMessage("CategoryName adı alanı boş bırakılamaz!!");
        }
    }
}
