using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.MetaDataTypes
{
    public class AuthorMetaData
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(ErrorMessage = "Maksimum 15 karakter girebilirsiniz.")]
        public string FirstName { get; set; }
    }
}
