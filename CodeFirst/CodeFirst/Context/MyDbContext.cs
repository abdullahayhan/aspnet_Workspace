using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Context
{
    public class MyDbContext : DbContext
    {
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EJL9033\MSSQLSERVER1;Database=BookStore;uid=sa;pwd=123");
            base.OnConfiguring(optionsBuilder);
        }*/

        // base bir üst makama parametre göndermede kullanılır.
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // nvarchar falan filan ayarlama
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<AppUserDetail> UserDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
