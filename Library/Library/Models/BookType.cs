using Library.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    [ModelMetadataType(typeof(BookTypeMetaData))]
    public class BookType:BaseEntity
    {
        public string Name { get; set; }

        // Relation Prop
        public List<Book> Books { get; set; }
    }
}
