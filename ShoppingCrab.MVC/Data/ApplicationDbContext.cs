using Microsoft.EntityFrameworkCore;
using ShoppingCrab.MVC.Models;

namespace ShoppingCrab.MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Clothes", DisplayOrder = 1 },
                new Category { Id = 2, Name = "books", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Shoes", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Jewellery", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Perfumes", DisplayOrder = 5 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
