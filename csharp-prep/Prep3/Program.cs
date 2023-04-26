using System;

class Program
{
    static void Main(string[] args)
    {


        // Core Assigments
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());


        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {

            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it! ");
            }


        }
    }
}