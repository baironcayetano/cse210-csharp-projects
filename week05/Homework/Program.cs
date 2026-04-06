using System;

class Program
{
    static void Main(string[] args)
    {   
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-9");
        Console.WriteLine("Math Assignment:");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters","European History","The causes of World War II");
        Console.WriteLine("WritingAssignment:");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}