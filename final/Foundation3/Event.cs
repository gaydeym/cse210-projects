using System;

public abstract class Event
{
    protected string _title = "";
    protected string _description = "";
    protected string _date = "";
    protected string _time = "";
    protected Address _address = new Address("");

    public Event(string title, string desc, string date, string time, string address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address.SetAddress(address);
    }

    public string StandardDetails()
    {
        string details = $"{_title} \n {_description} \n {_date}: {_time} \n {_address.GetAddress()}";
        return details;
    }
    
    public abstract string FullDetails();

    public abstract string ShortDescription();
    
}