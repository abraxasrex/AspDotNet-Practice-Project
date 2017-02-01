using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class Address {
        public string Street {get; set; }
        public string City {get; set; }
    }

    public class Customer {
        //FirstName, LastName, ShippingAddress, and BillingAddress properties
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public Address ShippingAddress {get; set;}
        public Address BillingAddress {get; set;}
    }
}