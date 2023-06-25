using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class EternalGoal : Goal
{
    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return _points;
    }
}