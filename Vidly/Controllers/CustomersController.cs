using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // Begin : Querying Objects - Populating Data from DB
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.Include(c => c.MembershipType).ToList(); // Include MembershipType to populate(Eager Loading)
        }
        // End : Querying Objects - Populating Data from DB

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
