using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Initialazier
{
    public static class DataInitialazier
    {
       public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { ID=1,UserName="administrator",Password= password1, Role=Enums.Role.admin},
                new AppUser() { ID = 2, UserName = "Abdullah", Password = password2, Role = Enums.Role.user }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student() { ID=1,FirstName="Mert",LastName="Ayhan",Gender=Enums.Gender.Erkek},
                new Student() { ID = 2, FirstName = "Elif", LastName = "Ayhan", Gender = Enums.Gender.Kadın },
                new Student() { ID = 3, FirstName = "Çidem", LastName = "Ayhan", Gender = Enums.Gender.Kadın },
                new Student() { ID = 4, FirstName = "Aşkın", LastName = "Ayhan", Gender = Enums.Gender.Erkek }
                );

            modelBuilder.Entity<StudentDetail>().HasData(
                new StudentDetail() { ID=1,StudentID=1,SchoolNumber=100,BirthDay=new DateTime(1994,04,19)},
                new StudentDetail() { ID = 2, StudentID = 2, SchoolNumber = 99, BirthDay = new DateTime(1995, 6, 19) },
                new StudentDetail() { ID = 3, StudentID = 3, SchoolNumber = 98, BirthDay = new DateTime(1967, 3, 20) },
                new StudentDetail() { ID = 4, StudentID = 4, SchoolNumber = 97, BirthDay = new DateTime(1967, 6, 12) }
                );
        }
    }
}
