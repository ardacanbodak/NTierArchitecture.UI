using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {

        public ProductRepository(ApplicationDbContext context) : base(context)
        {


        }
    }
}
