using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Order:BaseEntity
    {
        // böyle yazarsak otomatik foreignKey oluyor zaten 
        public int AppUserID { get; set; }
        // Realitional Property
        // [ForeignKey("UserID")] MESELA
        public AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
