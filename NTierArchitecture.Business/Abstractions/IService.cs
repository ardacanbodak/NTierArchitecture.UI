using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Abstractions
{
    public interface IService<T> where T : Entity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        IEnumerable<T>? GetAll();
        T? GetByID(Guid id);
        public bool IfEntityExists(T entity);
    }
}
