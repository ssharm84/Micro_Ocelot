using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderService.Models;
namespace OrderService.Models
{
    public class OrderMap
    {
        public OrderMap(EntityTypeBuilder<Order> entity)
        {
            entity.HasKey(t=>t.OrderID);
            entity.Property(t=>t.OrderName);
        }
    }
}