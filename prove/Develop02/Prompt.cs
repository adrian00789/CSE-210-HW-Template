using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator // PromptGenerator class
{
    static void Main(string[] args)
    {   
        //Propmps storage
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        //Menu display and loop for choice options, every choice calls a function
        //until user press 5 to exit
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Random random = new Random();
                int index = random.Next(prompts.Count);
                Console.WriteLine(prompts[index]);
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                Console.Write("Additional information (optional): ");
                string additionalInfo = Console.ReadLine();
                journal.AddEntry(new Entry(prompts[index], response, additionalInfo));
            }
            else if (choice == 2)
            {
                journal.DisplayJournal();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.LoadFile(filename);
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}