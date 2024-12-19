using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class SupplierRepository : GenericRepository<Supplier>
    {
        public SupplierRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
