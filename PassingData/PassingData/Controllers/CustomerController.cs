using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customers = new List<Customer>()
            {
                new Customer(){FirstName="Mert",LastName="Ayhan"},
                new Customer(){FirstName="Elif",LastName="Ayhan"},
                new Customer(){FirstName="Aşkın",LastName="Ayhan"},

            };
        public IActionResult UseViewModel()
        {
            Product product = new Product() { ProductName = "Monitör", CategoryName="Elektronik",UnitPrice=5};
            string date = DateTime.Now.ToString();
            CustomerAndProductVM vm = new CustomerAndProductVM() {customers=customers , product= product, date=date };
            return View(vm);
        }


        public IActionResult UseTuple()
        {
            Product product = new Product() { ProductName = "Telefon", CategoryName = "Elektronik", UnitPrice = 5 };
            string date = DateTime.Now.ToString();
            (List<Customer>,Product,string) sentUsingTuple=(customers, product, date);
            return View(sentUsingTuple);
        }
    }
}
