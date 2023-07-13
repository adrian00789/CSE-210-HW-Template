using System;
using System.Collections.Generic;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double exerciseTime, int laps)
    : base(date, exerciseTime)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _exerciseTime) * 60;
    }

    public override double GetPace()
    {
        return _exerciseTime / GetDistance();
    }
}