using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Authors : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Relation Prop
        public List<Book> Books { get; set; }
    }
}
