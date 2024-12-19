using FluentValidation;
using FluentValidation.Results;
using NTierArchitecture.Business.Abstractions;
using NTierArchitecture.Business.Validators;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Abstractions;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Services
{
    public class ProductService : IService<Product>
    {
        private readonly ProductRepository _productRepository;
        public ProductService(ProductRepository pRepo)
        {
            _productRepository = pRepo;
        }
        public void Add(Product product)
        {
            ProductValidator pVal = new();
            ValidationResult result = pVal.Validate(product);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _productRepository.Add(product);

        }

        public void Update(Product product)
        {
            ProductValidator pVal = new();
            ValidationResult pVal1 = pVal.Validate(product);
            if (!pVal1.IsValid)
            {
                _productRepository.Update(product);
            }
        }

        public void Delete(Guid productId)
        {

            var pr = _productRepository.GetByID(productId);

            if (pr.IsActive)
            {
                throw new Exception("Aktif veya Devamlılığı olan ürün silinemez!!");
            }
            

            if (pr.Discontinued)
            {
                throw new Exception("Devamlılığı olan ürün silinemez!!");
            }
            _productRepository.Delete(productId);
        }
        public IEnumerable<Product>? GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Category>? GetAllCategory(CategoryService cService)
        {
            CategoryService _categoryService;
            _categoryService = cService;
            return _categoryService.GetAll();
        }
        public IEnumerable<Supplier>? GetAllSupplier(SupplierService sService)
        {
            SupplierService _supplierService;
            _supplierService = sService;
            return _supplierService.GetAll(); 
        }


        public Product? GetByID(Guid productId)
        {
            return _productRepository.GetByID(productId);
        }
        public bool IfEntityExists(Product entity)
        {
            return _productRepository.IfEntityExists(p => p.ProductName == entity.ProductName);
        }
        public bool ProductNameExists(string productName)
        {
            return _productRepository.GetAll().Any(c => c.ProductName == productName);
        }

    }
}
