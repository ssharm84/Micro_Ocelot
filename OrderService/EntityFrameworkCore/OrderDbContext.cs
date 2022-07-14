using Microsoft.EntityFrameworkCore;
using OrderService.Models;
namespace OrderService.EntityFrameworkCore
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new OrderMap(modelBuilder.Entity<Order>());

        }
         public DbSet<Order> Orders{get;set;}
        
    }
}