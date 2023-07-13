using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double exerciseTime, double speed)
    : base(date, exerciseTime)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * _exerciseTime;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}