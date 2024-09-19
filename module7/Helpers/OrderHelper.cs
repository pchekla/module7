using module7.Models;

namespace module7.Helpers
{
    // Статический класс для работы с заказами
    public static class OrderHelper
    {
        // Статический метод для подсчета общей стоимости заказа
        public static decimal CalculateTotalPrice<TDelivery, TProduct>(Order<TDelivery, TProduct> order) where TDelivery : Delivery where TProduct : Product
        {
            decimal total = 0;
            foreach (var product in order.Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}