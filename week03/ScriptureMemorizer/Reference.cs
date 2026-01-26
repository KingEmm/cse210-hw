using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endverse;
    }
    public string GetDisplayText()
    {
        if (_endVerse == 0)
            return $"{_book} {_chapter} : {_verse}";

        return $"{_book} {_chapter} : {_verse} - {_endVerse}";
    }
}