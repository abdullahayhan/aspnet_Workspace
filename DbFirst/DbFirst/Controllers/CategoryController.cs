using DbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbFirst.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext _db;
        public CategoryController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
