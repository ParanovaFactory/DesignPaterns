using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();
        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void ComplateOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice, decimal productTotalPrice)
        {
            orderDetail.OrderId = orderId;
            orderDetail.CustomerId = customerId;
            orderDetail.ProductId = productId;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            productTotalPrice = productPrice * productCount;
            orderDetail.ProductTotalPrice = productTotalPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productId, productCount);
        }

        public void ComplateOrder(int customerId)
        {
            order.CustomerId = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
