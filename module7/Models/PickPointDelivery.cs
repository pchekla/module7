namespace module7.Models
{
    // Класс для доставки в пункт выдачи
    public class PickPointDelivery : Delivery
    {
        public string PickPointName { get; private set; }

        // Конструктор с параметрами
        public PickPointDelivery(string address, string pickPointName) : base(address)
        {
            PickPointName = pickPointName;
        }

        // Переопределенный метод для доставки
        public override void Deliver()
        {
            Console.WriteLine($"Pick-up delivery to {PickPointName}, Address: {Address}.");
        }
    }
}