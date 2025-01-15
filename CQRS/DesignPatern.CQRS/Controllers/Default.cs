using DesignPatern.CQRS.CQRSPattern.Commands;
using DesignPatern.CQRS.CQRSPattern.Handlers;
using DesignPatern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DesignPatern.CQRS.Controllers
{
    public class Default : Controller
    {
        private readonly GetProductQueryHandler _handler;
        private readonly CrateProductCommentHandler _product;
        private readonly GetProductByIdQueryHandler _byId;
        private readonly RemoveProductCommentHandler _remove;
        private readonly GetProdeuctByIdQueryHandler _update;
        private readonly UpdateProductCommandHandler _updateProduct;

        public Default(GetProductQueryHandler handler, CrateProductCommentHandler product, GetProductByIdQueryHandler byId, RemoveProductCommentHandler remove, GetProdeuctByIdQueryHandler update, UpdateProductCommandHandler updateProduct)
        {
            _handler = handler;
            _product = product;
            _byId = byId;
            _remove = remove;
            _update = update;
            _updateProduct = updateProduct;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CreateProductComment create)
        {
            _product.Handle(create);
            return RedirectToAction("Index");
        }

        public IActionResult GetProduct(int id)
        {
            var values = _byId.Handle(new GetProductByIdQuery(id));
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            _remove.Handle(new RemoveProductComment(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _update.Handle(new GetProductByIdUpdateQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(UpdateProductCommned cmd)
        {
            _updateProduct.Handle(cmd);
            return RedirectToAction("Index");
        }
    }
}
