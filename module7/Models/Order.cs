namespace module7.Models
{
    // Обобщенный класс для заказа
    public class Order<TDelivery, TProduct> where TDelivery : Delivery
    {
        // Свойства заказа
        public TDelivery Delivery { get; private set; }
        public List<TProduct> Products { get; private set; }
        public int Number { get; private set; }
        public string Description { get; private set; }

        // Конструктор с параметрами
        public Order(TDelivery delivery, List<TProduct> products, int number, string description)
        {
            Delivery = delivery;
            Products = products;
            Number = number;
            Description = description;
        }

        // Метод для отображения адреса доставки
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // Индексатор для доступа к продуктам
        public TProduct this[int index]
        {
            get => Products[index];
            set => Products[index] = value;
        }

        // Перегрузка оператора + для добавления продукта
        public static Order<TDelivery, TProduct> operator +(Order<TDelivery, TProduct> order, TProduct product)
        {
            order.Products.Add(product);
            return order;
        }
    }
}