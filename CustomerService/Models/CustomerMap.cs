using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CustomerService.Models
{
    public class CustomerMap
    {
        public CustomerMap(EntityTypeBuilder<Customer> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.CustomerID);
            entityTypeBuilder.Property(t => t.Name).IsRequired();
            entityTypeBuilder.Property(t => t.Phone).IsRequired();
        }
    }
}