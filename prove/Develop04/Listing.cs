using System;
using System.Collections.Generic;
using System.Threading;
public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private Random _random;

        public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            _random = new Random();
        }

        public override void Run()
        {
            string prompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            Thread.Sleep(3000);
            Console.WriteLine("Start listing items...");

            DateTime startTime = DateTime.Now;

            int itemCount = 0;
            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items.");
        }
    }