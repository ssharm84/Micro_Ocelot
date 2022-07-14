using Microsoft.AspNetCore.Mvc;
using OrderService.Repository;
using System.Collections.Generic;
using System.Linq;
namespace OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController:ControllerBase
    {
        IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        [HttpGet("OrderDetails")]
        public IActionResult GetOrderDetails()
        {
            return Ok(this._orderRepository.GetOrderList().ToList());
        }
    }
}