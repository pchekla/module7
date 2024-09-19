using module7.Models;

namespace module7.Extensions
{
    // Класс методов расширения для заказов
    public static class OrderExtensions
    {
        // Метод расширения для подсчета количества продуктов
        public static int ProductCount<TDelivery, TProduct>(this Order<TDelivery, TProduct> order) where TDelivery : Delivery
        {
            return order.Products.Count;
        }
    }
}