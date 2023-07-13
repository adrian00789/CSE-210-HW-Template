using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double exerciseTime, double distance)
    : base(date, exerciseTime)
    {
        _distance = distance;
    }

    public override double GetDistance() 
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _exerciseTime) * 60;
    }

    public override double GetPace()
    {
        return _exerciseTime / _distance;
    }
}