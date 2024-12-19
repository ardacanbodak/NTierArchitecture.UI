using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Services
{
    public class SupplierService : IService<Supplier>
    {
        private readonly SupplierRepository _supplierRepository;

        public SupplierService(SupplierRepository sRepo)
        {
            _supplierRepository = sRepo;
        }

        public void Add(Supplier entity)
        {
            SupplierValidator sVal = new();
            ValidationResult result = sVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _supplierRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            var spl = _supplierRepository.GetByID(id);
            if (spl.IsActive)
            {
                throw new Exception("Aktif supplier silinemez.");
            }
            _supplierRepository.Delete(id);

        }

        public IEnumerable<Supplier>? GetAll()
        {
            return _supplierRepository.GetAll();
        }

        public Supplier? GetByID(Guid id)
        {
            return _supplierRepository.GetByID(id);
        }

        public void Update(Supplier entity)
        {
            SupplierValidator sVal= new();
            ValidationResult sVal1 = sVal.Validate(entity);
            if (sVal1.IsValid)
            {
                _supplierRepository.Add(entity);
            }
        }
        public bool CompanyNameExists(string CompanyName)
        {
            return _supplierRepository.GetAll().Any(s => s.CompanyName == CompanyName);
        }

        public bool CompanyNameExists(string CompanyName, Guid excludeId)
        {
            return _supplierRepository.GetAll().Any(s => s.CompanyName == CompanyName && s.Id != excludeId);
        }
        public bool IfEntityExists(Supplier entity)
        {
            return _supplierRepository.IfEntityExists(s => s.CompanyName == entity.CompanyName);
        }
    }
}
