using Microsoft.AspNetCore.Mvc;
using ShoppingCrab.MVC.Data;
using ShoppingCrab.MVC.Models;

namespace ShoppingCrab.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _context.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
