using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Services
{
    public class EmployeeService : IService<Employee>
    {
        private readonly EmployeeRepository _employeeRepository;
        public EmployeeService(EmployeeRepository empRepo)
        {
            _employeeRepository = empRepo;
        }
        public void Add(Employee entity)
        {
            if (string.IsNullOrEmpty(entity.Name))
            {
                throw new Exception("Müşteri adı boş geçilemez.");
            }

            _employeeRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            //isActive=true olan Kategori silinemez.

            var cat = _employeeRepository.GetByID(id);

            if (cat.IsActive)
            {
                throw new Exception("Aktif olan bir kategori silinemez.");
            }
            _employeeRepository.Delete(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public Employee GetByID(Guid id)
        {
            return _employeeRepository.GetByID(id);
        }

        public void Update(Employee entity)
        {
            if (entity != null)
            {
                _employeeRepository.Update(entity);
            }
        }

        public bool IfEntityExists(Employee entity)
        {
            return _employeeRepository.IfEntityExists(c => c.Name == entity.Name);
        }
       
    }
}
