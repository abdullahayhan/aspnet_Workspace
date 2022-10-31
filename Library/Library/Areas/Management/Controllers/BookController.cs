using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookController : Controller
    {
        MyDbContext db;
        IBookRepository repoBook;
        IAuthorRepository repoAuthor;
        IBookTypeRepository repoBookType;
        public BookController(MyDbContext db,IBookRepository repoBook,IAuthorRepository repoAuthor,
            IBookTypeRepository repoBookType)
        {
            this.repoBook = repoBook;
            this.db = db;
            this.repoBookType = repoBookType;
            this.repoAuthor = repoAuthor;
        }


        // thenInclude dersen bir tablodan sonraki tabloya gidersin burada author tablosundan baska bir tabloya
        // gitmek isteseydik thenInclude dedikten sonra x değişkeni author gibi hareket edecekti.
        public IActionResult BookList()
        {
            List<Book> books = repoBook.GetBooks();
            return View(books);
        }

        public IActionResult Create()
        
        {
            List<AuthorDto> authors = repoAuthor.SelectAuthorDto();

            List<BookTypeDto> bookTypes = repoBookType.SelectBookTypeDto();

           return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix ="Item1")] Book book)
        {
            repoBook.Add(book);
            return RedirectToAction("BookList","Book",new { area="Management"});
        }

        public IActionResult Edit(int id)
        {
            Book book = repoBook.GetById(id);
            List<AuthorDto> authors = repoAuthor.SelectAuthorDto();
            List<BookTypeDto> bookTypes = repoBookType.SelectBookTypeDto();
            return View((book , authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            repoBook.Update(book);
            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }

        public IActionResult Delete(int id)
        {
            repoBook.Delete(id);
            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }
    }
}
