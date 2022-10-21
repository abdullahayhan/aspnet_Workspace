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
            modelBuilder.Entity<Operation>().Ignore("ID");
            modelBuilder.Entity<Operation>().HasKey("StudentID", "BookID");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Authors> Authors { get; set; }
    }
}
