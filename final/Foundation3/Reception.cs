using System;

public class Reception: Event
{
    private string _email = "";

    public Reception(string title, string desc, string date, string time, string address, string email): base(title, desc, date, time, address)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        string details = $"{_title} \n {_description} \n {_date}, {_time} \n {_address.GetAddress()} \n RSVP via email: {_email}";
        return details;   
    }
    
    public override string ShortDescription()
    {
        string details = $"Reception \n {_title} \n {_date}";
        return details;
    }

}