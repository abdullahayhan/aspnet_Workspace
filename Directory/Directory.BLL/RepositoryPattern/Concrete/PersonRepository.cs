using Directory.BLL.RepositoryPattern.Base_Abstract_;
using Directory.BLL.RepositoryPattern.Interfaces;
using Directory.DAL.Context;
using Directory.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.BLL.RepositoryPattern.Concrete
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        // base demek repositoryde db kullanıldıgı için oraya gönderiyoruz yani bir üst katmana veri gönderme
        public PersonRepository(MyDbContext db) : base(db) 
        {
        }
    }
}
