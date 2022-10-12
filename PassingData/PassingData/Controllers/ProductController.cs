using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "Abdullah Ayhan";
            return View(userName as Object);
        }

        public IActionResult UrunGoster()
        {
            Product product = new Product();
            product.ProductName = "TELEVİZYON";
            product.UnitPrice = 5;
            return View(product);
        }

        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>() 
            {    
                new Product(){ProductName="Bilgisiyar",CategoryName="Elektronik",UnitPrice=7},
                new Product(){ProductName="Telefon",CategoryName="Elektronik",UnitPrice=5},
                new Product(){ProductName="Buzdolabı",CategoryName="Beyaz Eşya",UnitPrice=3},
                new Product(){ProductName="Koltuk",CategoryName="Ev Eşyası",UnitPrice=2}
            };
            return View(products);
        }
    }
}
