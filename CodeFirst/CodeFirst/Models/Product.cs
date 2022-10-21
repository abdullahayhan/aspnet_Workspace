using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short UnitInStock { get; set; }
        public int CategoryID { get; set; }
        // Realitional Property
        public virtual Category Category { get; set; }
    }
}
