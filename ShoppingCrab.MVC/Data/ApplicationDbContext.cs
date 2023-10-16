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
    }
}
