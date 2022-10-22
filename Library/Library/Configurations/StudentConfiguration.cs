using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("varchar(30)").HasColumnName("İsim"); // default true
            builder.Property(x => x.LastName).IsRequired();
            builder.HasOne(s => s.StudentDetail)
                .WithOne(sd => sd.Student)
                .HasForeignKey<StudentDetail>(sd => sd.StudentID);
        }
    }
}
