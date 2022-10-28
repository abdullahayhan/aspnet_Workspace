using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.RepositoryPattern.Concrete
{
    public class BookTypeRepository : Repository<BookType>,IBookTypeRepository
    {
        public BookTypeRepository(MyDbContext db) : base(db)
        {
        }
        public List<BookTypeDto> SelectBookTypeDto()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new BookTypeDto()
            {
                ID = x.ID,
                Name = x.Name
            }).ToList();
        }
    }
}
