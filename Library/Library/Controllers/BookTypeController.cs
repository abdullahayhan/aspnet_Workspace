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
    public class BookTypeController : Controller
    {
        IBookTypeRepository repoBookType;
        public BookTypeController(IBookTypeRepository repoBookType)
        {
            this.repoBookType = repoBookType;
        }
        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = repoBookType.GetAll();
            return View(bookTypes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            repoBookType.Add(bookType);
            return RedirectToAction("BookTypeList");
        }

        public IActionResult Edit(int id)
        {
            BookType bookType = repoBookType.GetById(id);
            return View(bookType);
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            repoBookType.Update(bookType);
            return RedirectToAction("BookTypeList");
        }

        public IActionResult HardDelete(int id)
        {
            repoBookType.SpecialDelete(id);
            return RedirectToAction("BookTypeList");
        }
    }
}
