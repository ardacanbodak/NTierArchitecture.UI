using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName)
                .NotEmpty()
                .WithMessage("CategoryName adı alanı boş bırakılamaz!!")
                .MinimumLength(1)
                .WithMessage("CategoryName adı 1 karakterden az olamaz!!");
            RuleFor(c => c.Description)
                .NotEmpty()
                .WithMessage("Description alanı boş bırakılamaz!!")
                .MinimumLength(1)
                .WithMessage("Description alanı 1 karakterden az olamaz!!");
        }

    }
}
