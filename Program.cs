public class Product<T>
{
    public string Name { get; set; }
    public T Price { get; set; }

    public Product(string name, T price)
    {
        Name = name;
        Price = price;
    }

    public void Sell()
    {
        Console.WriteLine("Вы продали: " + Name + " за " + Price + " руб.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Product<double> bread = new Product<double>("Хлеб", 45.5);
        bread.Sell();

        Product<string> milk = new Product<string>("Молоко", "Нет в наличии. 0 рублей");
        milk.Sell();
        Console.ReadLine();
    }
}
