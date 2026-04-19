using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>
        {
            new Running(40,20),
            new Cycling(120,20),
            new Swimming(50,5),
        };

        Console.WriteLine("Summaries in km");
        foreach(Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary(true));
        }
    }
}