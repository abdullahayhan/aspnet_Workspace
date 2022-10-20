using System;
using System.Collections.Generic;

#nullable disable

namespace CinemaDbTableWithSqlConnection.Models
{
    public partial class Category
    {
        public Category()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
