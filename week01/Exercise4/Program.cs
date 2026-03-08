using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number = 1;
        List<int> numbers = new List<int>();

        while (number != 0){
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0){
                numbers.Add(number);
            }
        }

        int sum = 0; 
        int largestNumber = 0;

        foreach (int value in numbers){
            sum += value;
            if (value > largestNumber){
                largestNumber = value;
            }
        }

        float averageNumber = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {averageNumber}");
        Console.WriteLine($"The largest is: {largestNumber}"); 
    }
}