using System;

/*
* Author: Bairon Cayetano
* Features: 
*   - Added a functionality that reads a scripture verse and its reference from the console
*   - Added validation for the scriptures with multiple verses to avoid invalid references like 1 Nefi 0:3-1
*   - Added a new class called Memorization Manager which handles the input from the console.
* Usage: 
*   Run this program and when it asks for a scripture you can type your favorite scripture or simply use one
*   of the ones I wrote in the ReadMe.md file.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Program");
        MemorizationManager memorizationManager = new MemorizationManager();

        Reference reference = memorizationManager.GetReference();
        string scriptureText = memorizationManager.GetText();
        
        Scripture scripture = new Scripture(reference,scriptureText);


        bool exitProgram = false;
        while (!exitProgram){
            Console.WriteLine("Press Enter to continue. Type 'quit' to end");
            string input = Console.ReadLine().ToLower();
            
            if (input == "quit" || scripture.isCompletlyHidden()){
                exitProgram = true;    
            }

            if (!exitProgram)
            {
                Console.Clear();
                Random random = new Random();
                int maxNumber = scripture.TextLength() <= 3 ? 1 : 3;
                int randomNumber = random.Next(1,maxNumber);
                scripture.HideRandomWords(randomNumber);
                scripture.Display();
                exitProgram = scripture.isCompletlyHidden();
            }
        }

        Console.WriteLine("Bye!");
    }
}