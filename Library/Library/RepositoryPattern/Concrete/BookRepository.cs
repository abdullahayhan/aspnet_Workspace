using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.RepositoryPattern.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        MyDbContext db;
        public BookRepository(MyDbContext db) : base(db)
        {
            this.db = db;
        }

        public List<Book> GetBooks()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).Include(x => x.Author)
                .Include(x => x.BookType).ToList();
        }
    }
}
