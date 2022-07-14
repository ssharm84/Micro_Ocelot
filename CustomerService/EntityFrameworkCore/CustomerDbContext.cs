using Microsoft.EntityFrameworkCore;
using CustomerService.Models;
namespace CustomerService.EntityFrameworkCore
{
    public class CustomerDbContext:DbContext
    {
        public CustomerDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CustomerMap(modelBuilder.Entity<Customer>());

        }
         public DbSet<Customer> Customers{get;set;}

    }
}