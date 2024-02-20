using System;

public abstract class Exercise
{
    protected string _date = "";
    protected double _length = 0;

    public Exercise(string date, double len)
    {
        _date = date;
        _length = len;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();
    
    public abstract string Summary();

}