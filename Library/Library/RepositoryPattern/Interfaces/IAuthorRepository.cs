using Library.Dto;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository: IRepository<Authors>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
