namespace module7.Models
{
    // Класс для домашней доставки
    public class HomeDelivery : Delivery
    {
        public string CourierName { get; private set; }

        // Конструктор с параметрами
        public HomeDelivery(string address, string courierName) : base(address)
        {
            CourierName = courierName;
        }

        // Переопределенный метод для доставки
        public override void Deliver()
        {
            Console.WriteLine($"Home delivery to {Address} by {CourierName}.");
        }
    }
}
