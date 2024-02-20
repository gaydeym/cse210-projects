using System;

public class Swimming: Exercise
{
    private double _laps= 0;

    public Swimming(string date, double len, double laps): base(date, len)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        double dist = _laps * 50 /1000 *0.62;
        return dist;
    }

    public override double Speed()
    {
        double speed = (Distance()/_length) * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = _length/Distance();
        return pace;
    }

    public override string Summary()
    {
        string summary = $"{_date} Swimming ({_length} min) - Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
        return summary;
    }

}