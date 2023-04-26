using System;

class Program
{

    //Call all functions
    static void Main(string[] args)
    {

        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }




    //Functions
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int favoriteNumber)
    {
        int squareOperation = favoriteNumber * favoriteNumber;
        return squareOperation;
    }

    static void DisplayResult(string userName, int squareOperation)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareOperation} ");
    }



}