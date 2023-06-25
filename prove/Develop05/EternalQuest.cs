using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class EternalQuest
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Run()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"Current score: {_score}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void CreateNewGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int choice = int.Parse(Console.ReadLine());
        Goal newGoal = null;

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal { _name = name, _description = description, _points = points };
                break;
            case 2:
                newGoal = new EternalGoal { _name = name, _description = description, _points = points };
                break;
            case 3:
                Console.Write("Enter times required to complete: ");
                int timesRequired = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(timesRequired, bonusPoints) { _name = name, _description = description, _points = points };
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }

        _goals.Add(newGoal);
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string completionStatus = goal.IsComplete() ? "[X]" : "[ ]";
            string timesCompleted = goal is ChecklistGoal ? $" Completed {((ChecklistGoal)goal)._timesCompleted}/{((ChecklistGoal)goal)._timesRequired} times" : "";
            Console.WriteLine($"{i + 1}. {completionStatus} {goal._name} - {goal._description}{timesCompleted}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter the name of the file to save: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_goals.Count);
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal)
                {
                    writer.WriteLine("Simple");
                }
                else if (goal is EternalGoal)
                {
                    writer.WriteLine("Eternal");
                }
                else if (goal is ChecklistGoal)
                {
                    writer.WriteLine("Checklist");
                    writer.WriteLine(((ChecklistGoal)goal)._timesRequired);
                    writer.WriteLine(((ChecklistGoal)goal)._bonusPoints);
                }
                writer.WriteLine(goal._name);
                writer.WriteLine(goal._description);
                writer.WriteLine(goal._points);
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Enter the name of the file to load: ");
        string fileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(fileName))
        {
            _score = int.Parse(reader.ReadLine());
            int goalCount = int.Parse(reader.ReadLine());
            _goals.Clear();

            for (int i = 0; i < goalCount; i++)
            {
                string goalType = reader.ReadLine();
                Goal goal = null;

                if (goalType == "Simple")
                {
                    goal = new SimpleGoal();
                }
                else if (goalType == "Eternal")
                {
                    goal = new EternalGoal();
                }
                else if (goalType == "Checklist")
                {
                    int timesRequired = int.Parse(reader.ReadLine());
                    int bonusPoints = int.Parse(reader.ReadLine());
                    goal = new ChecklistGoal(timesRequired, bonusPoints);
                }

                goal._name = reader.ReadLine();
                goal._description = reader.ReadLine();
                goal._points = int.Parse(reader.ReadLine());

                _goals.Add(goal);
            }
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter the number of the goal to record: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            _score += goal.RecordEvent();
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}