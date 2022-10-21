using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        // Foregin key
        public int AppUserID { get; set; }
        // Realitional Property
        public AppUser AppUser { get; set; }
    }
}
