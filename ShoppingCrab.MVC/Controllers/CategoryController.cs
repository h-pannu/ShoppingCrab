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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            //if(category.Name == category.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("Name", "Category Name cannot contain Admin keyword");
            //}
            //if (category.Name.ToLower() == "Admin")
            //{
            //    ModelState.AddModelError("", "Category Name cannot contain Admin keyword");
            //}

            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
