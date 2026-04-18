using System.Collections.Generic;
using System.IO;
class GoalManager
{
    private List<Goal> _goals;
    private double _score;
    private double _level;
    
    public GoalManager(){
        _goals  = new List<Goal>{};
        _score = 0;
        _level = 0;
    }

    private void UpdateLevel()
    {
        _level = _score / 1000;
    }

    private void UpdateScore(double points)
    {
        _score += points;
        UpdateLevel();
    }

    private int GetUserLevel(){
        return (int)_level;
    } 

    private int GetUserScore()
    {
        return (int)_score;
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"Score: {GetUserScore()} points");
        Console.WriteLine($"Level: {GetUserLevel()}");
    }

    private string GetInput(string inputText){
        Console.WriteLine(inputText);
        return Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.Clear();
        List<string> goalTypes = new List<string>
        {
            "Simple Goal", "Eternal Goal", "Checklist Goal"
        };

        Console.WriteLine("Type of Goals");
        int counter = 1;
        foreach(string goalType in goalTypes){
            Console.WriteLine($"{counter}. {goalType}");
            counter += 1;
        }
        string userInput = GetInput("Enter the number of type of goal you want to create:");
        int choice = int.Parse(userInput);
        while (choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3");
            userInput = GetInput("Invalid choice. Please enter the number of type of goal you want to create:");
            choice = int.Parse(userInput);
        }

        Console.Clear();

        string goalName = GetInput("Enter the name of your goal:");
        string goalDescription = GetInput("Enter the description of your goal:");
        string textInput = choice == 3 ? "Enter the points you will receive every time you complete this goal" : "Enter the points you will receive for completing this goal";
        string pointsInput = GetInput(textInput);
        int points = int.Parse(pointsInput);
        while(points <= 0)
        {
            pointsInput = GetInput("Invalid points. Please enter a positive number greater than zero");
            points  = int.Parse(pointsInput);
        }
        Console.Clear();

        switch(choice){
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(goalName,goalDescription,points);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(goalName,goalDescription,points);
                _goals.Add(eternalGoal);
                break;
            case 3:
                userInput = GetInput("Enter the number of times you need to complete this goal");
                int timesToComplete = int.Parse(userInput);
                while(timesToComplete < 1)
                {
                    userInput = GetInput("Invalid number. Please enter the number of times you need to complete this goal");
                    timesToComplete = int.Parse(userInput);
                }
                ChecklistGoal checklistGoal = new ChecklistGoal(goalName,goalDescription,points, timesToComplete,500);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("No goal created. Invalid choice.");
                break;
        }
    }

    public void ListGoals()
    {
        Console.Clear();
        int counter = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
            counter += 1;
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        string userInput = GetInput("Which goal did you accomplish? Enter the number:");
        int choice = int.Parse(userInput);
        while(choice <= 0 || choice > _goals.Count)
        {   
            ListGoals();
            userInput = GetInput("Invalid choice. Please enter a number corresponding to the goal you accomplishd");
            choice = int.Parse(userInput);
        }

        Goal selectedGoal = _goals[choice - 1];
        double pointsBefore = selectedGoal.GetPointsEarned();
        selectedGoal.RecordEvent();
        double pointsAfter = selectedGoal.GetPointsEarned();
        double difference = pointsAfter - pointsBefore;
        UpdateScore(difference);
    }

    public void SaveGoals()
    {
        string fileName = "mygoals.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(GetUserScore());
            foreach(Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Saved!");
    }

    public void LoadGoals()
    {
        _goals = new List<Goal>();
        string fileName = "mygoals.txt";
        string[] lines = File.ReadAllLines(fileName);

        int counter = 0;
        foreach(string line in lines)
        {
            if(counter == 0)
            {
                _score = double.Parse(line);
                UpdateLevel();
                counter += 1;
                continue;
            }

            string[] parts = line.Split(",");
            string goalType = parts[0];
            switch (goalType)
            {
                case "Simple":
                    SimpleGoal simpleGoal = new SimpleGoal(parts);
                    _goals.Add(simpleGoal);
                    break;
                case "Eternal":
                    EternalGoal eternalGoal = new EternalGoal(parts);
                    _goals.Add(eternalGoal);
                    break;
                case "Checklist":
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts);
                    _goals.Add(checklistGoal);
                    break;
                default:
                    break;
            }
        } 
        Console.WriteLine("Loaded!");
    }

}