using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden= false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden)
            return true;

        return false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string underscore = "";
            for(int i=0; _text.Count() > i; i++)
            {
                underscore = $"{underscore}_";
            }
            return underscore;
        }

        return _text;
    }
}