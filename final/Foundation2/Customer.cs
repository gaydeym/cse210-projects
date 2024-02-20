using System;

public class Customer
{
    private string _name = "";
    private Address _address = new Address();

    public string Name
    {
        get => _name;
    }

    public Customer()
    {
    }

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        Address address = new Address(street, city, state, country);
        _address = address;
    }

    public bool IsUsa()
    {
        return _address.IsUsa();
    }

    public string ShippingAddress()
    {
        return _address.GetStringRepresentation();
    }
}