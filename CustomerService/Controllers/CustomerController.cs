using Microsoft.AspNetCore.Mvc;
using CustomerService.Repository;
namespace CustomerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController:ControllerBase
    {
        ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }
        [HttpGet("CustomerDetails")]
        public IActionResult GetCustomerDetails()
        {
            return Ok(this._customerRepository.GetCustomerList());
        }
    }
}