using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Services
{
    public class CustomerService : IService<Customer>
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService(CustomerRepository custRepo)
        {
            _customerRepository = custRepo;
        }
        public void Add(Customer entity)
        {
            if (string.IsNullOrEmpty(entity.CustomerName))
            {
                throw new Exception("Müşteri adı boş geçilemez.");
            }

            _customerRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            //isActive=true olan Kategori silinemez.

            var cat = _customerRepository.GetByID(id);

            if (cat.IsActive)
            {
                throw new Exception("Aktif olan bir kategori silinemez.");
            }
            _customerRepository.Delete(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetByID(Guid id)
        {
            return _customerRepository.GetByID(id);
        }

        public void Update(Customer entity)
        {
            if (entity != null)
            {
                _customerRepository.Update(entity);
            }
        }

        public bool IfEntityExists(Customer entity)
        {
            return _customerRepository.IfEntityExists(c => c.CustomerName == entity.CustomerName);
        }
    }
}
