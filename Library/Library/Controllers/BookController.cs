using Library.Context;
using Library.Dto;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        MyDbContext db;
        public BookController(MyDbContext db)
        {
            this.db = db;
        }


        // thenInclude dersen bir tablodan sonraki tabloya gidersin burada author tablosundan baska bir tabloya
        // gitmek isteseydik thenInclude dedikten sonra x değişkeni author gibi hareket edecekti.
        public IActionResult BookList()
        {
           List<Book> books =  db.Books.Where(x=>x.Status!=Enums.DataStatus.Deleted).Include(x=>x.Author)
                .Include(x => x.BookType).ToList();
            
            return View(books);
        }

        public IActionResult Create()
        
        {
           List<AuthorDto> authors = db.Authors.Where(x=>x.Status != Enums.DataStatus.Deleted).Select(x=>
           new AuthorDto() {
               FirstName=x.FirstName,
               LastName=x.LastName,
               ID=x.ID
           }).ToList();

            List<BookTypeDto> bookTypes = db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x=>
            new BookTypeDto() 
            {
                ID=x.ID,
                Name=x.Name
            }).ToList();

           return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix ="Item1")] Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return RedirectToAction("BookList");
        }

        public IActionResult Edit(int id)
        {
            Book book = db.Books.Find(id);
            List<AuthorDto> authors = db.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
             new AuthorDto()
             {
                 FirstName = x.FirstName,
                 LastName = x.LastName,
                 ID = x.ID
             }).ToList();
            List<BookTypeDto> bookTypes = db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
          new BookTypeDto()
          {
              ID = x.ID,
              Name = x.Name
          }).ToList();
            return View((book , authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            book.ModifiedDate = DateTime.Now;
            book.Status = Enums.DataStatus.Updated;
            db.Books.Update(book);
            db.SaveChanges();
            return RedirectToAction("BookList");
        }

        public IActionResult Delete(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}
