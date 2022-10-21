using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    [Table("Kategoriler")]
    public class Category: BaseEntity
    {
        [Required,MaxLength(30)]
        public string CategoryName { get; set; }
        [Column(TypeName ="nvarchar(300)")]
        public string Description { get; set; }

        // Realitional Property
        public virtual List<Product> Products { get; set; }
    }
}
