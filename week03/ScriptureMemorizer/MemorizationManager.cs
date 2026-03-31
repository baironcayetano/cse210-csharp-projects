class MemorizationManager
{
    private string _bookName;
    private int _chapter;

    private int _verse;
    private int _endVerse;

    private string _scriptureText;

    private Reference _reference;
    public MemorizationManager()
    {
        _bookName = GetBookName();
        _chapter = GetChapterNumber();

        bool multipleVerses = NeedMultipleVerses();
        if (multipleVerses){
            bool validPatter = false;
            int attempts = 0;
            while (!validPatter)
            {
                if (attempts > 0)
                {
                    Console.WriteLine($"{_bookName} {_chapter}:{_verse}-{_endVerse} is not a valid reference");
                    Console.WriteLine("Please try again.");
                }
                Console.WriteLine("[First Verse]");
                _verse = GetVerseNumber();
                Console.WriteLine("[Last Verse]");
                _endVerse = GetVerseNumber();

                if(_endVerse >= _verse)
                {
                    validPatter = true;
                }
                ++attempts;
            }
        }

        else
        {
            _verse = GetVerseNumber();
            _endVerse = _verse;    
        }

        _scriptureText = GetScriptureText();
        
    }

    private string GetBookName()
    {
        int attempts = 0;
        string bookName = ""; 
        bool validBookName = false;
        
        while (!validBookName){    
            if(attempts > 0){
                Console.Clear();
                Console.WriteLine("Please enter a valid name");
            }

            Console.WriteLine("Enter the name of book:");
            bookName = Console.ReadLine();
            

            if (bookName.Length > 2 && bookName.Length <= 32){
                validBookName = true;
            }

            ++attempts;
        }

        Console.Clear();
        return bookName;
    }

    private int GetChapterNumber()
    {
        int attempts = 0;
        int chapter = 0; 
        bool validChapterNumber = false;
        
        while (!validChapterNumber){    
            if(attempts > 0){
                Console.Clear();
                Console.WriteLine("The number of the chapter isn't valid. Please try again.");
            }

            Console.WriteLine("Enter the chapter:");
            string userInput = Console.ReadLine();
            chapter = int.Parse(userInput);

            if (chapter > 0 && chapter < 150){
                validChapterNumber = true;
            }

            ++attempts;
        }

        Console.Clear();
        return chapter;
    }

    private bool NeedMultipleVerses()
    {
        int attempts = 0;
        bool needMultipleVerses = false;
        bool validAnswer = false;

        while (!validAnswer)
        {
            if (attempts > 0)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid answer. type 'y' for 'yes' or 'n' for 'no'");
            }

            Console.WriteLine("Do you need to memorize more than 1 verse? (y/n)");
            string answer = Console.ReadLine().ToLower();
            
            if(answer == "n" || answer == "y")
            {
                validAnswer = true;
                needMultipleVerses = answer == "y"; 
            }

            ++attempts;
        }

        Console.Clear();
        return needMultipleVerses;
    }
    private int GetVerseNumber()
    {
        int verseNumber = 0;
        int attempts = 0;
        bool validVerseNumber = false;
        
        while (!validVerseNumber){    
            if(attempts > 0){
                Console.Clear();
                Console.WriteLine("The number of the verse isn't valid. Please try again.");
            }

            Console.WriteLine("Enter the number of the verse:");
            string userInput = Console.ReadLine();
            verseNumber = int.Parse(userInput);
            

            if (verseNumber > 0 && verseNumber < 175){
                validVerseNumber = true;
            }

            ++attempts;
        }

        Console.Clear();
        return verseNumber;
    }

    private string GetScriptureText()
    {
        int attempts = 0;
        string scriptureText = ""; 
        bool validScriptureText = false;
        
        while (!validScriptureText){    
            if(attempts > 0){
                Console.Clear();
                Console.WriteLine("Please enter a valid text");
            }

            Console.WriteLine("Enter the text of the scripture");
            scriptureText = Console.ReadLine();
            

            if (scriptureText.Length > 2){
                validScriptureText = true;
            }

            ++attempts;
        }

        Console.Clear();
        return scriptureText;   
    }

    public Reference GetReference()
    {
        if(_endVerse == _verse)
        {
             _reference = new Reference(_bookName,_chapter,_verse);
        }
        else
        {
            _reference = new Reference(_bookName, _chapter, _verse, _endVerse);            
        }
        return _reference;
    }

    public string GetText()
    {
        return _scriptureText;
    }
}