using System;

public class Running: Exercise
{
    private double _distance = 0;

    public Running(string date, double length, double dist): base(date, length)
    {
        _distance = dist;
    }
    
    public override double Distance()
    {
        double dist = _distance;
        return dist;
    }

    public override double Speed()
    {
        double speed = (_distance/_length) * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = _length/_distance;
        return pace;
    }

    public override string Summary()
    {
        string summary = $"{_date} Running ({_length} min) - Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
        return summary;
    }

}