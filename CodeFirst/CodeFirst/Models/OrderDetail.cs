using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; }
        [Column(TypeName = "numeric(18,1)")]
        public decimal? TotalPrice { get; set; }
        //[Key,Column(Order=1)]
        public int OrderID { get; set; }
        //[Key, Column(Order = 2)] iki tane keyin varsa sıralarını belirtlemelisin tabloda 2. sırada olacaktır bu prop
        public int ProductID { get; set; }
        // Relational Property
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
