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
            // List<Authors> authors = db.Authors.ToList();
            List<Authors> authors = db.Authors.Where(a=>a.Status!=Enums.DataStatus.Deleted).ToList();
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

        public IActionResult Edit(int id)
        {
            Authors author = db.Authors.Find(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Authors author)
        {
            author.Status = Enums.DataStatus.Updated;
            author.ModifiedDate = DateTime.Now;
            db.Authors.Update(author);
            db.SaveChanges();
            return RedirectToAction("AuthorList");
        }

        // soft delete sadece uygulamada göstermez ama veritabanında bilgi hala vardır.
        public IActionResult Delete(int id)
        {
            Authors author =db.Authors.Find(id);
            author.Status = Enums.DataStatus.Deleted;
            author.ModifiedDate = DateTime.Now;
            db.Authors.Update(author);
            db.SaveChanges();
            return RedirectToAction("AuthorList");
        }
    }
}
