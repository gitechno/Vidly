using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            var customers = GetCustomers();
            return View(customers);
        }

        [Route("customers/info/{id}")]
        public ActionResult Info(int id)
        {
         
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if(customer == null)
                return HttpNotFound();
            return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer {Name = "Customer 1", Id = 1},
                new Customer {Name = "Customer 2", Id = 2},
                new Customer {Name = "Customer 3", Id = 3},
                new Customer {Name = "Customer 4", Id = 4},
                new Customer {Name = "Customer 5", Id = 5}
            };
        }
    }
}