using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer(){ Id=1, Name="John Smith"},
                new Customer(){ Id=2, Name="Mary Williams"}
            };
        }
        public IActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customers = GetCustomers();

            foreach (var customer in customers)
            {
                if (customer.Id == id)
                    return View(customer);
            }
            return NotFound();
        }
    }
}
