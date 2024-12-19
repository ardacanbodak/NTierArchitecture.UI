using FluentValidation;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(o => o.ProductID)
               .NotEmpty()
               .WithMessage("Ürün ID boş geçilemez.");

            RuleFor(o => o.OrderID)
              .NotEmpty()
              .WithMessage("Sipariş No boş geçilemez.");

            RuleFor(o => o.UnitPrice)
              .NotEmpty()
              .WithMessage("Lütfen bir ürün fiyatı giriniz.")
              .GreaterThan(0)
              .WithMessage("Ürün fiyatı pozitif bir değer olmalıdır.");

        }
    }
}
