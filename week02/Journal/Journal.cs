using System.Collections.Generic;
using System.IO;

class Journal{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _promptGenerator = new PromptGenerator();

    public void Write(){
        Console.WriteLine("Write (selected)");

        string promt = _promptGenerator.GetRandomPrompt();
        Console.WriteLine(promt);
        string entryText = Console.ReadLine();

        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToShortDateString();

        string optionText;
        int option = 0;

        while(option != 1 && option != 2)
        {
            Console.WriteLine("Would you like to add this entry to your favorites list?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            Console.Write("> ");
            optionText = Console.ReadLine();
            option = int.Parse(optionText);

            if (option != 1 && option != 2)
            {
                Console.WriteLine($"{option} is not a valid option. Please try it again");
            }   
        }

        Entry entry = new Entry();
        entry._prompt = promt;
        entry._entryContent = entryText;
        entry._date = date;
        entry._isFavorite = (option == 1) ? true : false;

        _entries.Add(entry);
    }

    public void DisplayAll(){
        Console.WriteLine("Display All (selected)");

        if(_entries.Count == 0)
        {
            Console.WriteLine("There are no entries to show");
            return;
        }

        foreach (Entry entry in _entries){
            entry.Display();
        }
   
    }

    public void DisplayFavorites(){
        Console.WriteLine("Display Favorites (selected)");

        if(_entries.Count == 0)
        {
            Console.WriteLine("There are no entries to show");
            return;
        }

        foreach (Entry entry in _entries)
        {
            if (entry._isFavorite)
            {
                entry.Display();    
            }
        }
    }

    public void Load(){
        Console.WriteLine("Load (selected)");
        Console.WriteLine("Enter the filename:");

        string fileName = Console.ReadLine();
        string[] fileContent = File.ReadAllLines(fileName);

        List<Entry> loadedEntries = new List<Entry>();

        foreach(string line in fileContent){

            string[] parts = line.Split("|");
            string date = parts[0];
            string prompt = parts[1];
            string entryContent = parts[2];
            string strIsFavorite = parts[3];

            Entry entry = new Entry();

            entry._date = date;
            entry._prompt = prompt;
            entry._entryContent = entryContent;
            entry._isFavorite = (strIsFavorite == "True") ? true : false;

            loadedEntries.Add(entry);
        }
        
        _entries = loadedEntries; 
    }

    public void Save(){
        Console.WriteLine("Save (selected)");
        
        if(_entries.Count == 0)
        {
            Console.WriteLine("You need at least one entry to save it as a file.");
            return;
        }

        Console.WriteLine("Enter the filename:");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryContent}|{entry._isFavorite}");   
            }   
        }

    }

}