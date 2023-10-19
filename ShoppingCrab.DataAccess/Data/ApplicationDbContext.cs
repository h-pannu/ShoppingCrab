using Microsoft.EntityFrameworkCore;
using ShoppingCrab.Models;

namespace ShoppingCrab.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Clothes", DisplayOrder = 1 },
                new Category { Id = 2, Name = "books", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Shoes", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Jewellery", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Perfumes", DisplayOrder = 5 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Levis Pent", Description = "Beautiful Pent with 6 pockets", ListPrice = 60, Price = 57, Price50 = 52, Price100 = 48 },
                new Product { Id = 2, Name = "Diamond Necklace", Description = "Stunning necklace in heart shape", ListPrice = 70, Price = 67, Price50 = 62, Price100 = 58 },
                new Product { Id = 3, Name = "24 Carat Gold Ring", Description = "Real gold ring made of 24 carat gold", ListPrice = 92, Price = 87, Price50 = 82, Price100 = 78 },
                new Product { Id = 4, Name = "Adidas Perfume", Description = "Adidas perfume with a nice fragnence to use before workout", ListPrice = 30, Price = 27, Price50 = 22, Price100 = 18 },
                new Product { Id = 5, Name = "Boss perfume", Description = "Impress other people with rose fragnence.", ListPrice = 45, Price = 37, Price50 = 32, Price100 = 28 },
                new Product
                {
                    Id = 6,
                    Name = "Fortune of Time",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80
                },
                new Product
                {
                    Id = 7,
                    Name = "Dark Skies",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20
                },
                new Product
                {
                    Id = 8,
                    Name = "Vanish in the Sunset",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35
                },
                new Product
                {
                    Id = 9,
                    Name = "Cotton Candy",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55
                },
                new Product
                {
                    Id = 10,
                    Name = "Rock in the Ocean",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20
                },
                new Product
                {
                    Id =11,
                    Name = "Leaves and Wonders",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
