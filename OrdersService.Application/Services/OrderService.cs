using OrdersService.Application.Interfaces;
using OrdersService.Domain.Entities;
using OrdersService.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Orders>> GetOrdersFromDb1Async()
        {
            return await _orderRepository.GetOrdersFromDb1Async();
        }

        public async Task<IEnumerable<Orders>> GetOrdersFromDb2Async()
        {
            return await _orderRepository.GetOrdersFromDb2Async();
        }

        public async Task<IEnumerable<Orders>> GetOrdersAsync(bool useDb1)
        {
            return await _orderRepository.GetOrdersAsync(useDb1);
        }
    }
}
