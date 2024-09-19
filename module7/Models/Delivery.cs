namespace module7.Models
{
    // Абстрактный базовый класс для всех видов доставки
    public abstract class Delivery
    {
        // Инкапсулированное свойство для адреса доставки
        public string Address { get; protected set; }

        // Конструктор с параметром
        public Delivery(string address)
        {
            Address = address;
        }

        // Абстрактный метод для вывода деталей доставки
        public abstract void Deliver();
    }
}