using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        GoalManager goalManager = new GoalManager();
        int menuSize = PrintMenu();
        int choice = int.Parse(Console.ReadLine());
        while(choice != 7)
        {
            if (choice > menuSize || choice < 0)
            {
                Console.Clear();
                Console.WriteLine("Please select a valid option");
                menuSize = PrintMenu();
                choice = int.Parse(Console.ReadLine());
                continue;
            }

            if(choice == 0)
            {
                menuSize = PrintMenu();
                choice = int.Parse(Console.ReadLine());
                continue;
            }

            Console.Clear();

            switch (choice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoals();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    goalManager.DisplayPlayerInfo();
                    break;
                default:
                    break;
            }
            choice = 0;
        }

    }

    static int PrintMenu()
    {
        Console.WriteLine("Menu:");
        List<string> menuOptions = new List<string>
        {
            "Create New Goal",
            "List Goals",
            "Save Goals",
            "Load Goals",
            "Record Event",
            "Player Info",
            "Quit",
        };
        int counter = 1;
        foreach(string option in menuOptions)
        {
            Console.WriteLine($"{counter}. {option}");
            counter += 1;
        }
        Console.WriteLine("Select an option from the menu");
        return menuOptions.Count;
    }
}