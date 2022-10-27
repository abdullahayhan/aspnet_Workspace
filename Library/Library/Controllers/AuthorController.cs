using Library.Context;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {
        MyDbContext db;
        public AuthorController(MyDbContext db)
        {
            this.db = db;
        }
        public IActionResult AuthorList()
        {
            List<Authors> authors = db.Authors.ToList();
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Authors author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
            return RedirectToAction("AuthorList");
        }
    }
}
