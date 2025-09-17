using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=MyDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Username);
                entity.HasIndex(u => u.Email).IsUnique();
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Code);
            });

            modelBuilder.Entity<Product>(product =>
            {
            product.HasData(
                new Product
                {
                    Code = "P001",
                    Name = "Laptop",
                    Price = 999.99m,
                    Category = "Electronics",
                    ImageUrl = "https://cdn.mos.cms.futurecdn.net/FUi2wwNdyFSwShZZ7LaqWf.jpg", // laptop
                    Quantity = 10,
                    Discount = 0.10m
                },
                new Product
                {
                    Code = "P002",
                    Name = "Smartphone",
                    Price = 499.99m,
                    Category = "Electronics",
                    ImageUrl = "https://m.media-amazon.com/images/I/61fh21u3DJL.jpg", // smartphone
                    Quantity = 20,
                    Discount = 0.05m
                },
                new Product
                {
                    Code = "P003",
                    Name = "Headphones",
                    Price = 79.99m,
                    Category = "Accessories",
                    ImageUrl = "https://m.media-amazon.com/images/I/61kcjN3yo+L._UF894,1000_QL80_.jpg", // headphones
                    Quantity = 50,
                    Discount = 0.15m
                },
                new Product
                {
                    Code = "P004",
                    Name = "Coffee Maker",
                    Price = 39.99m,
                    Category = "Home Appliances",
                    ImageUrl = "https://i5.walmartimages.com/seo/Mr-Coffee-5-Cup-Programmable-Coffee-Maker-25-oz-Mini-Brew-Brew-Now-or-Later-Black_972164db-9b9b-42e2-9463-80f40fb360e3.2423b7d6d6d77ec31ed140a0cece9662.jpeg", // coffee maker
                    Quantity = 15,
                    Discount = 0.20m
                },
                new Product
                {
                    Code = "P005",
                    Name = "Gaming Console",
                    Price = 299.99m,
                    Category = "Electronics",
                    ImageUrl = "https://i5.walmartimages.com/asr/78ecb78a-f45e-40c9-98c2-e059bc4e93b6.781d30e03254cb41d2297474de4d50c0.jpeg", // gaming console
                    Quantity = 5,
                    Discount = 0.10m
                },
                new Product
                {
                    Code = "P006",
                    Name = "Electric Kettle",
                    Price = 24.99m,
                    Category = "Home Appliances",
                    ImageUrl = "https://cdn.mafrservices.com/pim-content/EGY/media/product/647543/1737017022/647543_main.jpg", // electric kettle
                    Quantity = 30,
                    Discount = 0.25m
                },
                new Product
                {
                    Code = "P007",
                    Name = "Smartwatch",
                    Price = 199.99m,
                    Category = "Electronics",
                    ImageUrl = "https://m.media-amazon.com/images/I/71pbEc1KO3L._AC_SL1500_.jpg", // smartwatch
                    Quantity = 12,
                    Discount = 0.10m
                },
                new Product
                {
                    Code = "P008",
                    Name = "Bluetooth Speaker",
                    Price = 49.99m,
                    Category = "Accessories",
                    ImageUrl = "https://m.media-amazon.com/images/I/81oRzXfs2zL._UF894,1000_QL80_.jpg", // speaker
                    Quantity = 25,
                    Discount = 0.15m
                }

                );
            });
        }
    }
}
