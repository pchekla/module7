using module7.Models;
using module7.Helpers;
using module7.Extensions;

namespace DeliveryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем продукты
            var product1 = new Product("Laptop", 1200m);
            var product2 = new Product("Smartphone", 800m);

            // Создаем доставку
            var homeDelivery = new HomeDelivery("123 Main St", "John Doe");

            // Создаем заказ
            var order = new Order<HomeDelivery, Product>(homeDelivery, new List<Product> { product1, product2 }, 1, "Electronics Order");

            // Используем индексатор
            Console.WriteLine($"First product: {order[0].Name}");

            // Добавляем продукт с помощью перегрузки оператора
            order += new Product("Tablet", 300m);

            // Отображаем информацию о заказе
            order.DisplayAddress();
            Console.WriteLine($"Total price: {OrderHelper.CalculateTotalPrice(order)}");
            Console.WriteLine($"Product count: {order.ProductCount()}");
        }
    }
}