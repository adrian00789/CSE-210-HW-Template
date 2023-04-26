using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {



        //List
        List<int> numbers = new List<int>();

        //Adding Numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum of numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Average number
        float counting = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {counting}");

        //Largest number

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest){
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");



    }
}