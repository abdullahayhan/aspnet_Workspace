using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.MetaDataTypes
{
    public class BookTypeMetaData
    {
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; }
    }
}
