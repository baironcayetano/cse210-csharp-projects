using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>
        {
            new Running(40,20),
        };

        foreach(Exercise exercise in exercises)
        {
            Console.WriteLine("Summary in km");
            Console.WriteLine(exercise.GetSummary(true));
        }
    }
}