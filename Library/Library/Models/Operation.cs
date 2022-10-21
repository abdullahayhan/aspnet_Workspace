using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Operation : BaseEntity
    {
        public int StudentID { get; set; }
        public int BookID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relation Prop
        public Student Student { get; set; }
        public Book Book { get; set; }
    }
}
