using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime _date;
    protected double _exerciseTime;

    public Activity(DateTime date, double exerciseTime)
    {
        _date = date;
        _exerciseTime = exerciseTime;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} - {GetType().Name}\nTime: {_exerciseTime} mins\nDistance: {GetDistance():0.0}km\n" +
                    $"Speed: {GetSpeed():0.0}kph\nPace: {GetPace():0.0}min per km";
    }
}
