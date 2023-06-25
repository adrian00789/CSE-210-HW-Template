using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ChecklistGoal : Goal
{
    public int _timesCompleted;
    public int _timesRequired;
    public int _bonusPoints;

    public ChecklistGoal(int timesRequired, int bonusPoints)
    {
        _timesRequired = timesRequired;
        _bonusPoints = bonusPoints;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _timesRequired;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _timesRequired)
        {
            return _points + _bonusPoints;
        }
        return _points;
    }
}