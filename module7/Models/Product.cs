namespace module7.Models
{
    // Класс для представления продукта
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        // Конструктор с параметрами
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Метод для отображения информации о продукте
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name}: ${Price}");
        }
    }
}