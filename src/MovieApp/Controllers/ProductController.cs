using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWebAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI.API
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        static List<Product> _products = new List<Product>
            {
                new Product {Id=1, Name="Milk", Price=2.33m},
                new Product {Id=2, Name="Cheese", Price=5.44m},
                new Product {Id=3, Name="Apples", Price=2.50m}
            };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _products.Add(product);
              Console.WriteLine("success!");
            return Created("/products/" + product.Id, product);
        }

    }
}