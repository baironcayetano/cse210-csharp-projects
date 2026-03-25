using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionWithoutParams = new Fraction();
        Fraction fractionWithOneParam = new Fraction(5);
        Fraction fraction = new Fraction(3,4);
        Console.WriteLine("Constructor without params:");
        Console.WriteLine(fractionWithoutParams.GetFractionString());
        Console.WriteLine("Contructor with one parameter:");
        Console.WriteLine(fractionWithOneParam.GetFractionString());
        Console.WriteLine("Constructor with two parameters:");
        Console.WriteLine(fraction.GetFractionString());
        fraction.SetNumerator(1);
        fraction.SetDenominator(3);
        Console.WriteLine("With Getters and Setters:");
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine("Decimal Value:");
        Console.WriteLine(fraction.GetDecimalValue());

    }
}