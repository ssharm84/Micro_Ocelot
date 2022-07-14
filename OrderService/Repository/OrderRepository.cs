using System.Collections.Generic;
using OrderService.Models;
using OrderService.EntityFrameworkCore;
using System.Linq;
namespace OrderService.Repository
{
    public class OrderRepository : IOrderRepository
    {
        OrderDbContext _order;
        public OrderRepository(OrderDbContext order)
        {
            this._order = order;
        }
        public Order GetOrderById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Order> GetOrderList()
        {
            return this._order.Orders.ToList();
        }

        public int SaveOrder(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}