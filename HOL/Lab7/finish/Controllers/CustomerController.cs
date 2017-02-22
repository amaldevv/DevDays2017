
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using finish.Models;
namespace finish.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("GetCustomers")]
        public IEnumerable<Customer> Get()
        {
            var cust = new List<Customer>(){
                new Customer(){ FirstName = "John", LastName ="Doe", Age=33},
                new Customer(){ FirstName = "Mark", LastName ="Spencer", Age=21},
                new Customer(){ FirstName = "Ken", LastName ="Wright", Age=39},
            };
        
            return cust;
        }
    }
}