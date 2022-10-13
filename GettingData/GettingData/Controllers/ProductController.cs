using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product>() 
        {
            new Product(){ID=1,ProductName="Kitap" ,CategoryName="Okul"},
            new Product(){ID=2,ProductName="Televizyon",CategoryName="Elektronik" },
            new Product(){ID=3,ProductName="Kalem" ,CategoryName="Okul"},
            new Product(){ID=4,ProductName="Silgi" ,CategoryName="Okul"},
        };

        public IActionResult GetAllProduct()
        {
            return View(products);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x=>x.ID==id);
            if (product==null)
            {
                ViewBag.Error = "Verilen Id ile bir ürün bulunamadı";
            }
            return View(product);
        }

        public IActionResult GetProductByCategoryName(string categoryName)
        {
            List<Product> myProducts = products.FindAll(x=>x.CategoryName==categoryName);
            if (myProducts == null)
            {
                ViewBag.Error = "Girilen Kategori İle İlgili Bir Ürün Bulunamadı";
            }
            return View(myProducts);
        }
    }
}
