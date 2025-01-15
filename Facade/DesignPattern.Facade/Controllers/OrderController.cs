using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();
        OrderFacade order = new OrderFacade();

        public IActionResult OrderList()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewOrderDetail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice, decimal productTotalPrice)
        {
            productTotalPrice = productPrice * productCount;
            order.ComplateOrderDetail(customerId, productId, orderId, productCount, productPrice, productTotalPrice);
            return RedirectToAction("OrderList");
        }

        [HttpGet]
        public IActionResult AddNewOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewOrder(int customerId)
        {
            order.ComplateOrder(customerId);
            return RedirectToAction("OrderList");
        }
    }
}
