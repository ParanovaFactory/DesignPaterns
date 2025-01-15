using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatter.Repository.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product c)
        {
            _productService.TInsert(c);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var value = _productService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Edit(Product c)
        {
            _productService.TUpdate(c);
            return RedirectToAction("Index");
        }
    }
}
