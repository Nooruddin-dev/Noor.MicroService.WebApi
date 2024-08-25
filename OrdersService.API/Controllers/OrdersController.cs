using Microsoft.AspNetCore.Mvc;
using OrdersService.Application.Interfaces;
using System.Threading.Tasks;

namespace OrdersService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("from-db1")]
        public async Task<IActionResult> GetOrdersFromDb1()
        {
            var orders = await _orderService.GetOrdersFromDb1Async();
            return Ok(orders);
        }

        [HttpGet("from-db2")]
        public async Task<IActionResult> GetOrdersFromDb2()
        {
            var orders = await _orderService.GetOrdersFromDb2Async();
            return Ok(orders);
        }

        [HttpGet("dynamic")]
        public async Task<IActionResult> GetOrders(bool useDb1)
        {
            var orders = await _orderService.GetOrdersAsync(useDb1);
            return Ok(orders);
        }
    }
}
