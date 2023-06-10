using System;
using System.Collections.Generic;
using System.Threading;
// I did a verification if the user put a letter instead of a number
// from the menu for the extra credit and exceeds
// core requirements, that start at line 23 of program.cs. 
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice;
            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadLine();
                continue;
            }
            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
            }

            if (activity != null)
            {
                Console.Clear();
                activity.Start();
                activity.Run();
                activity.Finish();
                Console.ReadKey();
            }

        }
    }
}
