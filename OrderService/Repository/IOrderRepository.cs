using System.Collections.Generic;
using OrderService.Models;
namespace OrderService.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrderList();
        Order GetOrderById(int id);
        int SaveOrder(Order order);
    }
}