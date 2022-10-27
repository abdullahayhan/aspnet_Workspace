using Library.Context;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class BookTypeController : Controller
    {
        MyDbContext db;
        public BookTypeController(MyDbContext db)
        {
            this.db = db;
        }
        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = db.BookTypes.ToList();
            return View(bookTypes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            db.BookTypes.Add(bookType);
            db.SaveChanges();
            return RedirectToAction("BookTypeList");
        }
    }
}
