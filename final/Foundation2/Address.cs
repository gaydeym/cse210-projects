using System;

public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    
    public string StreetAddress
    {
        set {_streetAddress = value;}
    }

    public Address()
    {
    }
    
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetStringRepresentation()
    {
        string address = $"{_streetAddress}, \n {_city}, {_state} \n {_country}";
        return address;
    }

}