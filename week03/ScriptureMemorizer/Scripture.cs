using System;

class Scripture
{
    private Reference _refrence;
    private List<Word> _word = new List<Word>();
    private int len;

    public Scripture(Reference reference, string text)
    {
        _refrence=reference;
    
        string[] words = text.Split(' ');
        len = words.Count();

        foreach(string word in words)
        {
            Word letters = new Word(word);
            _word.Add(letters);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        try
        {
            _word[numberToHide].Hide();
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.Write("Invalid index !!!");
        }
            
    }

    public string GetDisplayText()
    {
        if(_word.Count == 0)
        {
            return "";
        }
        string word = "";
        for(int i=0; i < _word.Count; i++){
            if(i == 0)
                word = _word[i].GetDisplayText();
            else
                word = $"{word} {_word[i].GetDisplayText()}";
        }
        return word;
    }

    public bool IsCompletelyHidden()
    {
        for(int i=0; i < _word.Count(); i++)
        {
            if (!_word[i].IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}