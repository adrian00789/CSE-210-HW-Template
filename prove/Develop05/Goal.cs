using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;

    public abstract bool IsComplete();
    public abstract int RecordEvent();
}