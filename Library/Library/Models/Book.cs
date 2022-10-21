using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int AuthorID { get; set; }
        public int BookTypeID { get; set; }

        // Relation Prop
        public BookType BookType { get; set; }
        public Authors Author { get; set; }
        public List<Operation> Operations { get; set; }
    }
}
