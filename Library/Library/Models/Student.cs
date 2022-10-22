using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        // Relation Prop
        public List<Operation> Operations { get; set; }
        public virtual StudentDetail StudentDetail { get; set; }
    }
}
