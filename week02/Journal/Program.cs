using System;
using System.Collections.Generic;

/**
FEATURES:
    - Created a 'isFavorite' property so that each entry can be marked as favorite.
    - Propmts the user if He/She wants to add an entry to his/her 'favorites list'.
    - Created a DisplayFavorites method to display only the entries marked as 'favorites'.
    - Added a 'Display Favorites' option to the menu
**/

class Program
{
    static void Main(string[] args){
        
        Journal journal = new Journal();
        List<string> actions = new List<string>{
            "Write",
            "Display All",
            "Display Favorites",
            "Load",
            "Save",
            "Quit",
        };

        int action = 0;
        string userInput;

        Console.WriteLine("Welcome to the Journal Program!");
        while (action != 6){

            Console.WriteLine("\nPlease select one of the following choices:");
            for(int i = 0; i < actions.Count; i++){
                int listNumber = i+1;
                Console.WriteLine($"{listNumber}. - {actions[i]}");
            }
            Console.WriteLine("What would you like to do?");

            userInput = Console.ReadLine();
            action = int.Parse(userInput);

            switch (action){
                case 1:
                    journal.Write();
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    journal.DisplayFavorites();
                    break;
                case 4:
                    journal.Load();
                    break;
                case 5:
                    journal.Save();
                    break;
                case 6:
                    Console.WriteLine("Quit (selected)");
                    break;
                default:
                    Console.WriteLine("Invalid number. Please select a valid option");
                    break;
            }
        }
    }
}