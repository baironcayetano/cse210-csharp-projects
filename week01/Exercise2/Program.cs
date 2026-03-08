using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.Write("Enter a grade in percentage: %");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        //Default if you've got a grade < 60%
        string letter;
        bool passed = true;

        if (gradePercentage >= 90){
            letter = "A";
        }else if(gradePercentage >= 80){
            letter = "B";
        }else if(gradePercentage >= 70){
            letter = "C";
        }else if(gradePercentage >= 60){
            letter = "D";
            passed = false;
        }else{
            letter = "F";
            passed = false;
        }

        Console.WriteLine($"Your grade is {letter}");
        if (passed){
            Console.WriteLine($"Congratulations! You passed the class! Keep it up!");
        }else{
            Console.WriteLine($"Sorry, You did not pass the class. Try again and your hard work will be paid off!");
        }
    }
}