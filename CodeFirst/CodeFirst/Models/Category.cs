using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Category: BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // Realitional Property
        public virtual List<Product> Products { get; set; }
    }
}
