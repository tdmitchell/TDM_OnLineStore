using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.Entity;
using TDM_OnLineStore.Repository.Config;

namespace TDM_OnLineStore.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        ///Mapping Properties and Relationships (Construct the Model for this Context)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Inform ALL Configuration Classes here            
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            ///Seed data
            modelBuilder.Entity<Payment>().HasData(
                new Payment()
                {
                    Id = 1,
                    Name = "Boleto",                        // ------------------------ !!!! TRANSLATE !!!! ------------------------ 
                    Description = "Payment by Boleto"       // ------------------------ !!!! TRANSLATE !!!! ------------------------ 
                },
                 new Payment()
                 {
                     Id = 2,
                     Name = "Credict Card",                        
                     Description = "Payment by Credict Card"
                 },
                 new Payment()
                 {
                     Id = 3,
                     Name = "Deposit",
                     Description = "Payment by Deposit"
                 }
                );

            ///Seed data
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Product Test 1",
                    Description = "Description for Product 1",
                    Price = 10
                },
                 new Product()
                 {
                     Id = 2,
                     Name = "Credict Card",
                     Description = "Description for Product 2",
                     Price = 20.2M
                 },
                 new Product()
                 {
                     Id = 3,
                     Name = "Deposit",
                     Description = "Description for Product 3",
                     Price = 30.3M
                 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}