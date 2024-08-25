using OrdersService.Domain.Entities;
using OrdersService.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace OrdersService.Infrastructure.Persistence.Repositories
{
    public class OrderRepository
    {
        private readonly ApplicationDbContext1 _context1;
        private readonly ApplicationDbContext2 _context2;

        public OrderRepository(ApplicationDbContext1 context1, ApplicationDbContext2 context2)
        {
            _context1 = context1;
            _context2 = context2;
        }

        public async Task<IEnumerable<Orders>> GetOrdersFromDb1Async()
        {
            try
            {
                return await _context1.Orders.ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }

        public async Task<IEnumerable<Orders>> GetOrdersFromDb2Async()
        {
            return await _context2.Orders.ToListAsync();
        }

        public async Task<IEnumerable<Orders>> GetOrdersAsync(bool useDb1)
        {
            if (useDb1)
            {
                return await _context1.Orders.ToListAsync();
            }
            else
            {
                return await _context2.Orders.ToListAsync();
            }
        }
    }
}
