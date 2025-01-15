using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.BusinessLayer.Concrate;
using DesignPattern.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatter.Repository.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category c)
        {
            _categoryService.TInsert(c);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = _categoryService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Category c)
        {
            _categoryService.TUpdate(c);
            return RedirectToAction("Index");
        }
    }
}
