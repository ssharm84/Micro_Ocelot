using System.Collections.Generic;
using CustomerService.Models;
using CustomerService.EntityFrameworkCore;
using System.Linq;
namespace CustomerService.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        CustomerDbContext _customer;
        public CustomerRepository(CustomerDbContext customer)
        {
            this._customer = customer;
        }
        public Customer GetCustomerById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return this._customer.Customers.ToList();
        }

        public int SaveCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}