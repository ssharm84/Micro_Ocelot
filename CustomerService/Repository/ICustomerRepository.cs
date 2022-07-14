using System.Collections.Generic;
using CustomerService.Models;
namespace CustomerService.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomerList();
        Customer GetCustomerById(int id);
        int SaveCustomer(Customer customer);

    }
}