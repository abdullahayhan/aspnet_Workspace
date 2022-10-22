using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class StudentDetail:BaseEntity
    {
        public int SchoolNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public int StudentID { get; set; }

        // Relational Property

        public virtual Student Student { get; set; }
    }
}
