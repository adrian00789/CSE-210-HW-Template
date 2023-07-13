using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 4.5),
            new Cycling(DateTime.Now, 60, 22),
            new Swimming(DateTime.Now, 45, 60)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary() + "\n");
        }
    }
}