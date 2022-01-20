using MyBlazorApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBlazorApp.CoreBusiness.Services
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers;
        public string UId { get; set; }

        public CustomerService()
        {
            UId = Guid.NewGuid().ToString();

            customers = new List<Customer>
            {
                new Customer {Id=1, Name="Tom" },
                new Customer {Id=2, Name="John" },
                new Customer {Id=3, Name="Ray" },
                new Customer {Id=4, Name="Jane" }
            };
        }

        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
