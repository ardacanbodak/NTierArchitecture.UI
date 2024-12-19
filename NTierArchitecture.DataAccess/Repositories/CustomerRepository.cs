using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.DataAccess.Repositories;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Business.Validators
{
    public class CustomerRepository : GenericRepository<Customer>
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
