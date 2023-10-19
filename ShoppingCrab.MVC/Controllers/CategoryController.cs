using Microsoft.AspNetCore.Mvc;
using ShoppingCrab.DataAccess.Data;
using ShoppingCrab.DataAccess.Repository.IRepository;
using ShoppingCrab.Models;

namespace ShoppingCrab.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.CategoryRepository.GetAll().ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Category Name cannot be same as Display Order");
            }
            if (category.Name.ToLower() == "Admin")
            {
                ModelState.AddModelError("", "Category Name cannot contain Admin keyword");
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.CategoryRepository.Add(category);
                _unitOfWork.Save();
                //_context.Categories.Add(category);
                //_context.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Category? category = _context.Categories.Find(id);
            Category? category = _unitOfWork.CategoryRepository.Get(u=>u.Id==id);

            //var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            //var category = _context.Categories.Where(i=>i.Id==id).FirstOrDefault();

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Category Name cannot be same as Display Order");
            }
            if (category.Name.ToLower() == "Admin")
            {
                ModelState.AddModelError("", "Category Name cannot contain Admin keyword");
            }

            if (ModelState.IsValid)
            {
                //_context.Categories.Update(category);
                //_context.SaveChanges();
                _unitOfWork.CategoryRepository.Update(category);
                _unitOfWork.Save();

                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Category? category = _context.Categories.Find(id);
            Category? category = _unitOfWork.CategoryRepository.Get(i=>i.Id==id);

            //var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            //var category = _context.Categories.Where(i=>i.Id==id).FirstOrDefault();

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            //Category? category = _context.Categories.Find(id);
            Category? category = _unitOfWork.CategoryRepository.Get(i=>i.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            //_context.Categories.Remove(category);
            //_context.SaveChanges();
            _unitOfWork.CategoryRepository.Remove(category);
            _unitOfWork.Save();

            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index", "Category");
        }
    }
}
