using OrdersService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Application.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<Orders>> GetOrdersFromDb1Async();
        Task<IEnumerable<Orders>> GetOrdersFromDb2Async();
        Task<IEnumerable<Orders>> GetOrdersAsync(bool useDb1);
    }
}
