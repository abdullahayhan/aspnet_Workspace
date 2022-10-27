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

        public IActionResult Edit(int id)
        {
            BookType bookType = db.BookTypes.Find(id);
            return View(bookType);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            bookType.Status = Enums.DataStatus.Updated;
            bookType.ModifiedDate = DateTime.Now;
            db.BookTypes.Update(bookType);
            db.SaveChanges();
            return RedirectToAction("BookTypeList");
        }

        public IActionResult HardDelete(int id)
        {
            BookType bookType = db.BookTypes.Find(id);
            db.BookTypes.Remove(bookType);
            db.SaveChanges();
            return RedirectToAction("BookTypeList");
        }
    }
}
