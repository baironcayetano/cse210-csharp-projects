using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guess my number proyect!");
        Random randomNumberGenerator= new Random();
        int magicNumber = randomNumberGenerator.Next(1,100);
        bool match = false;
        int count = 0;

        while (!match){
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guessNumber = int.Parse(userInput);

            string text;
            if (guessNumber == magicNumber){
                text = "You guessed it!";
                match = true;
            }else if(guessNumber > magicNumber){
                text = "Lower";
            }else{
                text = "Higher";
            }

            Console.WriteLine(text);
            count++;    
        }

        Console.WriteLine($"It took you {count} guess(es)!");
            
    }
}