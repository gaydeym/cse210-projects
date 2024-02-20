using System;

public class Lecture: Event
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lecture(string title, string desc, string date, string time, string address, string speaker, int cap): base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = cap;
    }

    public override string FullDetails()
    {
        string details = $"{_title} \n Speaker: {_speaker} \n {_description} \n {_date}, {_time} \n {_address.GetAddress()} \n capacity: {_capacity}";
        return details;   
    }
    
    public override string ShortDescription()
    {
        string details = $"Lecture \n {_title} \n {_date}";
        return details;
    }
}