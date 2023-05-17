using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction formula1 = new Fraction();
        Console.WriteLine(formula1.GetFractionsString());
        Console.WriteLine(formula1.GetDecimalValue());

        Fraction formula2 = new Fraction(5);
        Console.WriteLine(formula2.GetFractionsString());
        Console.WriteLine(formula2.GetDecimalValue());

        Fraction formula3 = new Fraction(3, 4);
        Console.WriteLine(formula3.GetFractionsString());
        Console.WriteLine(formula3.GetDecimalValue());

        Fraction formula4 = new Fraction(1, 3);
        Console.WriteLine(formula4.GetFractionsString());
        Console.WriteLine(formula4.GetDecimalValue());

    }
}