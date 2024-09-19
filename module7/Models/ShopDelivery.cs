namespace module7.Models
{
    // Класс для доставки в магазин
    public class ShopDelivery : Delivery
    {
        public string ShopName { get; private set; }

        // Конструктор с параметрами
        public ShopDelivery(string address, string shopName) : base(address)
        {
            ShopName = shopName;
        }

        // Переопределенный метод для доставки
        public override void Deliver()
        {
            Console.WriteLine($"Shop delivery to {ShopName}, Address: {Address}.");
        }
    }
}
