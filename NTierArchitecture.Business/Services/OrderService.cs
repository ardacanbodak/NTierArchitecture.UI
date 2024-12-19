using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System.Text;

namespace NTierArchitecture.Business.Services
{
    public class OrderService : IService<Order>
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepo)
        {
            _orderRepository = orderRepo;
        }

        public void Add(Order entity)
        {
            OrderValidator oVal = new OrderValidator();
            ValidationResult result = oVal.Validate(entity);

            if (!result.IsValid)
            {
                StringBuilder sb = new StringBuilder();
                result.Errors.ForEach(x => sb.AppendLine(x.ErrorMessage));
                throw new Exception(sb.ToString());
            }
            _orderRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var od = _orderRepository.GetByID(id);
            if (od != null)
            {
                _orderRepository.Delete(id);
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetByID(Guid id)
        {
            var od = _orderRepository.GetByID(id);
            if (od == null)
            {
                throw new Exception("Sipariş Bulunamadı.");
            }
            return od;
        }

        public bool IfEntityExists(Order entity)
        {
            return _orderRepository.IfEntityExists(o => o.Id == entity.Id);
        }

        public void Update(Order entity)
        {
            _orderRepository.Update(entity);
        }
    }
}