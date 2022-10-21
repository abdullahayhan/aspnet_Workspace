using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Order:BaseEntity
    {
        // FOREGİN KEY
        public int AppUserID { get; set; }
        // Realitional Property
        public AppUser AppUser { get; set; }
    }
}
