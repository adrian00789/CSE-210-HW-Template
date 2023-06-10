using System;
using System.Collections.Generic;
using System.Threading;
public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Start()
        {
            Console.WriteLine($"Starting {_name} Activity");
            Console.WriteLine(_description);
            Console.Write("Enter the duration of the activity in seconds: ");
            _duration = int.Parse(Console.ReadLine());


            //Visual
            Console.WriteLine("Prepare to begin...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public abstract void Run();

        public void Finish()
        {
            Console.WriteLine("Good job!");
            Thread.Sleep(2000);
            Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
            Thread.Sleep(3000);
        }
    }