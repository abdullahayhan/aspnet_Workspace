using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthorController : Controller
    {
        IAuthorRepository repoAuthor;
        public AuthorController(IAuthorRepository repoAuthor)
        {
            this.repoAuthor = repoAuthor;
        }
        public IActionResult AuthorList()
        {
            // List<Authors> authors = db.Authors.ToList();
            List<Authors> authors = repoAuthor.GetActives();
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Authors author)
        {
            repoAuthor.Add(author);
            return RedirectToAction("AuthorList");
        }

        public IActionResult Edit(int id)
        {
            Authors author = repoAuthor.GetById(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Authors author)
        {
            repoAuthor.Update(author);
            return RedirectToAction("AuthorList");
        }

        // soft delete sadece uygulamada göstermez ama veritabanında bilgi hala vardır.
        public IActionResult Delete(int id)
        {
            repoAuthor.Delete(id);
            return RedirectToAction("AuthorList");
        }
    }
}
