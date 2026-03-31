class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    } 

    public void Hide()
    {
        if (!_isHidden)
        {
            _isHidden = true;
        }
    }

    public string GetText()
    {
        string hiddenText = "";
        foreach (char letter in _text){
            hiddenText += "_";
        }
        return _isHidden ? hiddenText : _text;
    }
}
