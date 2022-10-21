using CodeFirst.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string RePassword { get; set; }
        public Role Role { get; set; }

        // Realitional Property
        // virtual otomatik olarak her istek atıldıgında appuserdetail de gelsin diye.
        public virtual AppUserDetail AppUserDetail { get; set; }
        public virtual List<Order> Orders  { get; set; }
    }
}
