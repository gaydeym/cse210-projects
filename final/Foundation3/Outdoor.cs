using System;

public class Outdoor: Event
{
    private string _weather = "";

    public Outdoor(string title, string desc, string date, string time, string address, string weather): base(title, desc, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        string details = $"{_title} \n {_description} \n {_date}, {_time} \n {_address.GetAddress()} \n weather forecast: {_weather}";
        return details;   
    }
    
    public override string ShortDescription()
    {
        string details = $"Outdoor Gathering \n {_title} \n {_date}";
        return details;
    }

}