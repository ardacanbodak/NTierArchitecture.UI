using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.DataAccess.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>
    {
        private readonly ApplicationDbContext _context;
        public OrderDetailRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<OrderDetail> GetOrderDetailByOrderID(Guid orderID)
        {
            return _context.OrderDetails.Where(od => od.OrderID == orderID);
        }

    }
}
