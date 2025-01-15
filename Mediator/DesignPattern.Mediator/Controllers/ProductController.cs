using DesignPattern.Mediator.MediatorPattern.Commands;
using DesignPattern.Mediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Mediator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllProductQuery());
            return View(values);
        }

        public async Task<IActionResult> Bring(int id)
        {
            var value = await _mediator.Send(new GetProductByIdQuery(id));
            return View(value);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var value = await _mediator.Send(new GetProductByIdUpdateQuery(id));
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductCommand updateProductCommand)
        {
            await _mediator.Send(updateProductCommand);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommand createProductCommand)
        {
            await _mediator.Send(createProductCommand);
            return RedirectToAction("Index");
        }
    }
}
