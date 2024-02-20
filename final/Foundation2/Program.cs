using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.CustomerAttributes("Alice", "123 Main St", "New York", "New York", "USA");
        order1.AddProduct("Notebook", "SKU123", 15.99, 2);
        order1.AddProduct("Pen", "SKU456", 2.99, 5);
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        Console.WriteLine();
        Console.WriteLine();

        Order order2 = new Order();
        order2.CustomerAttributes("Bob", "456 Oak St", "Los Angeles", "California", "USA");
        order2.AddProduct("Headphones", "SKU789", 49.99, 1);
        order2.AddProduct("USB Drive", "SKU321", 9.99, 3);
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}
