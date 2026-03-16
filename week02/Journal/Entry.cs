class Entry{
    public string _date;
    public string _prompt;
    public string _entryContent; 
    public bool _isFavorite;
    public void Display(){
        string favorite = _isFavorite ? "Yes" : "No";
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_entryContent}");
        Console.WriteLine($"Marked as favorite: ({favorite})");
    }
}