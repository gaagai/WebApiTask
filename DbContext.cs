using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyShoppingListApi.Models;

namespace MyShoppingListApi
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the 'Category' entity to map to the 'categories' table
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(c => c.CategoryId).HasColumnName("id");
            modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("name");
            modelBuilder.Entity<Order>().ToTable("orders");
            modelBuilder.Entity<Order>().Property(o => o.OrderId).HasColumnName("order_id");
            modelBuilder.Entity<Order>().Property(o => o.FullName).HasColumnName("full_name");
            modelBuilder.Entity<Order>().Property(o => o.FullAddress).HasColumnName("full_address");
            modelBuilder.Entity<Order>().Property(o => o.Email).HasColumnName("email");
            modelBuilder.Entity<Order>().Property(o => o.OrderItemsJson).HasColumnName("order_items_json");
        }
    }
}