using FluentValidation.Results;
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
    public class CategoryService : IService<Category>
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryService(CategoryRepository cRepo)
        {
            _categoryRepository = cRepo;
        }
        public void Add(Category entity)
        {
            CategoryValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _categoryRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
           /* CategoryValidator cVal = new();
            ValidationResult result = cVal.Validate(GetByID(id));

            if (string.IsNullOrEmpty(id.ToString()))
            {
                throw new Exception("Category alanı boş bırakılamaz");
            }*/
            

            var ctg = _categoryRepository.GetByID(id);

            if (ctg.IsActive)
            {
                throw new Exception("Aktif category silinemez!!");
            }
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category>? GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category? GetByID(Guid id)
        {
            return _categoryRepository.GetByID(id);
        }
        public bool IfEntityExists(Category entity)
        {
            return _categoryRepository.IfEntityExists(c => c.CategoryName == entity.CategoryName);
        }

        public void Update(Category entity)
        {
            CategoryValidator cVal = new();
            ValidationResult cVal1 = cVal.Validate(entity);
            if (cVal1.IsValid)
            {
                _categoryRepository.Update(entity);
            }
        }
        public bool CategoryNameExists(string categoryName)
        {
            return _categoryRepository.GetAll().Any(c => c.CategoryName == categoryName);
        }

        public bool CategoryNameExists(string categoryName, Guid excludeId)
        {
            return _categoryRepository.GetAll().Any(c => c.CategoryName == categoryName && c.Id != excludeId);
        }
    }
}
