using Library.Configurations;
using Library.Initialazier;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitialazier.Seed(modelBuilder);
            // Operation
            modelBuilder.ApplyConfiguration(new OperationConfiguration());

            // Author
            modelBuilder.ApplyConfiguration(new AuthorsConfiguration());

            // Student
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            // Book
            modelBuilder.ApplyConfiguration(new BookConfiguration());

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
