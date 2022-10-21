using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookType:BaseEntity
    {
        public string Name { get; set; }

        // Relation Prop
        public List<Book> Books { get; set; }
    }
}
