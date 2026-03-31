using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach(string word in text.Split(" ")){
            Word newWord = new Word(word);
            _words.Add(newWord);   
        } 
    }

    public int TextLength()
    {
       return _words.Count;
    }
    public bool isCompletlyHidden()
    {
        bool isHidden = true;
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                isHidden = false;
                break; 
            }
        }

        return isHidden;    
    }

    private int GetRandomWordIndex()
    {
        Random random = new Random();
        int randomIndex = random.Next(_words.Count);
        return randomIndex;
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = GetRandomWordIndex();
            bool wordIsHidden = _words[index].isHidden();

            if (wordIsHidden){
                for (int wordIndex = 0; wordIndex < TextLength(); wordIndex++)
                {
                    if (!_words[wordIndex].isHidden())
                    {
                        _words[wordIndex].Hide();
                        break;       
                    }
                }
            }
            else{
                _words[index].Hide();
            }
        }
    }

    
    public void Display()
    {
        Console.WriteLine(_reference.GetReferenceText());
        string text = "";
        foreach (Word word in _words)
        {
            text += " " + word.GetText();
        }
        Console.WriteLine(text);
    }

}