using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Abstractions;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _table;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }


        public void Add(T entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            _table.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public T? GetByID(Guid id)
        {
            return _table.Find(id);
        }
        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _table.Any(filter);
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
