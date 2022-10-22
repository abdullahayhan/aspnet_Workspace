using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Configurations
{
    public class AuthorsConfiguration : IEntityTypeConfiguration<Authors>
    {
        public void Configure(EntityTypeBuilder<Authors> builder)
        {
            builder.ToTable("Yazarlar");
            builder.Property(x => x.FirstName).HasColumnName("İsim");
            builder.Property(x => x.LastName).HasColumnName("Soyisim");
        }
    }
}
