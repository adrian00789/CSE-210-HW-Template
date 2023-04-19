using System;

class Program
{
    static void Main(string[] args)
    {
        // Core assigments
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // This is to know if we use the + or - symbol depending of the grade
        string sign = "";
        int lastDigit = gradeNumber % 10;
        
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // This is to ensure there is not A+ or F+/-
        if (gradeNumber >= 93 || gradeNumber <= 60)
        {
            sign = "";
        }
    


        // Display the message depending of the grade
        Console.WriteLine($"Your grade is: {letter}{sign}");


        if (gradeNumber >= 70)
        {
            Console.WriteLine("Good job!");
        }
        else
        {
            Console.WriteLine("You need to do better.");
        }
    }
}