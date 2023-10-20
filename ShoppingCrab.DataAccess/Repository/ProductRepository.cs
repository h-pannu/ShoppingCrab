using ShoppingCrab.DataAccess.Data;
using ShoppingCrab.DataAccess.Repository.IRepository;
using ShoppingCrab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCrab.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public void Update(Product product)
        {
            //_context.Products.Update(product);

            var objFromDb = _context.Products.FirstOrDefault(i=>i.Id == product.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = product.Name;
                objFromDb.Description = product.Description;
                objFromDb.Price = product.Price;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.CategoryId = product.CategoryId;
                if(objFromDb.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
