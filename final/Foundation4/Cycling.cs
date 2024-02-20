using System;

public class Cycling: Exercise
{
    private double _speed;

    public Cycling(string date, double len, double speed): base(date, len)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        double dist = (_speed/60) * _length;
        return dist;
    }

    public override double Pace()
    {
        double pace = Math.Pow((_speed/60),-1);
        return pace;
    }

    public override double Speed()
    {
        double speed = _speed;
        return speed;
    }

    public override string Summary()
    {
        string summary = $"{_date} Swimming ({_length} min) - Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
        return summary;
    }
    
}