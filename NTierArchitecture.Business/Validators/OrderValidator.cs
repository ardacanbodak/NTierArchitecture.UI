using FluentValidation;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.IsActive)
                .NotEmpty()
                .WithMessage("Aktif pasif alanı boş olamaz.");

            RuleFor(o => o.CustomerID)
                .NotEmpty()
                .WithMessage("Müşteri no boş geçilemez.");

            RuleFor(o => o.EmployeeID)
               .NotEmpty()
               .WithMessage("Çalışan no boş geçilemez.");
        }
    }
}
