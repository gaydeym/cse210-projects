using System;

public class Order
{
    private List<Product> _products = new List<Product>{};
    private Customer _customer = new Customer();

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double cost = 0;

        foreach (Product p in _products)
        {
            cost += p.GetTotalPrice();
        }

        if (_customer.IsUsa())
        {
            cost += 5;
        }
        else
        {
            cost+=35;
        }

        return cost;
    }

    public string PackingLabel()
    {
        string products = "";
        foreach (Product p in _products)
        {
            products += $"\n {p.Name}: {p.Id}";
        }
        return products;
    }

    public string ShippingLabel()
    {
        string shipping = $"{_customer.Name}\n {_customer.ShippingAddress()}";
        return shipping;
    }

    public void CustomerAttributes(string name, string street, string city, string state, string country)
    {
        Customer customer = new Customer(name, street, city, state, country);
        _customer = customer;
    }

}