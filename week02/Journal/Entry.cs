using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string entryText=null, string ptxt = null, string na=null)
    {
        _date = na ?? DateTime.Now.ToShortTimeString();
        _entryText = entryText;
    }
    public void SetAllEntry(string entryText=null, string ptxt = null, string na=null)
    {
        _date = na ?? DateTime.Now.ToString();
        _entryText = entryText ?? "No data was set";
    }

    public void Display()
    {
        _promptText = PromptGenerator.GetRandomPrompt();
        Console.Write($"{_promptText}\n> ");
        _entryText = Console.ReadLine();
        _date = DateTime.Now.ToString();
    }

    public string getPrompt()
    {
        return _promptText;
    }
    public string getEntryText()
    {
        return _entryText;
    }
    public string getDate()
    {
        return _date;
    }
}