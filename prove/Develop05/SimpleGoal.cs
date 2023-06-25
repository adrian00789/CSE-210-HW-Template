using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class SimpleGoal : Goal
{
    public bool _completed;

    public override bool IsComplete()
    {
        return _completed;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }
        return 0;
    }
}
