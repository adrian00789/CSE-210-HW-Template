using System;
using System.Collections.Generic;

public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return _title + "\n" + _description + "\n" + _date.ToString() + "\n" + _time
        + "\n" + _address.GetFullAddress();
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return GetType().Name + " - " + _title + " on " + _date.ToString("dd/MM/yyyy");
    }
}