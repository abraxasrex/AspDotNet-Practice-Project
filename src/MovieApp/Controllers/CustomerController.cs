using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWebAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI.API
{
    [Route("api/customers")]
    public class CustomerController: Controller
    {
          static List<Customer> _customers = new List<Customer>
            {
                new Customer { FirstName="Greg", LastName="Halloran", BillingAddress=new Address{
                        Street="Williamsburg",
                        City="Doggerton"
                    }, ShippingAddress=new Address{
                        Street="Ballon",
                        City="powpow"
                    }
                }

            };

               // GET: api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
           // Console.WriteLine("gettttt");
            return _customers;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine("success!");
            return Created("/customers/" + customer.FirstName, customer);
        }
    }

}