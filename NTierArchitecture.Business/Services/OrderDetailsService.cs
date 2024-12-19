using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Text;

namespace NTierArchitecture.Business.Services
{
    public class OrderDetailService : IService<OrderDetail>
    {
        private readonly OrderDetailRepository _orderDetailRepository;
        public OrderDetailService(OrderDetailRepository orderRepo)
        {
            _orderDetailRepository = orderRepo;
        }

        public void Add(OrderDetail entity)
        {
            OrderDetailValidator oVal = new OrderDetailValidator();
            ValidationResult result = oVal.Validate(entity);
            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(x => sb.AppendLine(x.ErrorMessage));
                throw new Exception(sb.ToString());
            }
        }

        public void Delete(Guid id)
        {
            var od = _orderDetailRepository.GetByID(id);
            if (od != null)
            {
                _orderDetailRepository.Delete(id);
            }
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetByID(Guid id)
        {
            var od = _orderDetailRepository.GetByID(id);
            if (od == null)
            {
                throw new Exception("Sipariş Bulunamadı.");
            }
            return od;
        }

        public void Update(OrderDetail entity)
        {
            _orderDetailRepository.Update(entity);
        }

        public bool IfEntityExists(OrderDetail entity)
        {
            return _orderDetailRepository.IfEntityExists(c => c.ProductID == entity.ProductID && c.OrderID == entity.OrderID);
        }

        public IEnumerable<OrderDetail> GetOrderDetails(Guid orderID)
        {
            return _orderDetailRepository.GetOrderDetailByOrderID(orderID);
        }
    }
}
