using System;
using System.Text.Json;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry=null)
    {
        if (newEntry == null)
        {
            newEntry.Display();
            _entries.Add(newEntry);
            return;
        } 
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry line in _entries)
        {
            Console.WriteLine("\n");
            Console.WriteLine(line.getPrompt());
            Console.WriteLine(line.getEntryText());
            Console.WriteLine(line.getDate());
            Console.WriteLine("\n");
        }
    }

    public void SaveToFile(string file)
    {
        // if (!File.Exists(file))
        //     Console.WriteLine("File does not Exist");
        
        if (!file.Contains(".txt"))
        {
            file += ".txt";
        }
        using (StreamWriter journalFile  = new StreamWriter(file))
            foreach(Entry ent in _entries)
            {
                {
                    journalFile.WriteLine($"{ent.getPrompt()} | {ent.getEntryText()} | {ent.getDate()}");      
                }
            };
    }
    public void LoadFile(string file)
    {
        if (!file.Contains(".txt"))
            file += ".txt";
        
        if (!File.Exists(file))
        {
            Console.WriteLine("\nFile does not Exist !!!\n");
            return;
        }
        
        string [] lines = System.IO.File.ReadAllLines(file);

        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            Console.WriteLine(parts[0]);
            Console.WriteLine(parts[1]);
            Console.WriteLine(parts[2]);
        }
    }
    public void loadJson(string file)
    {
        if (!file.Contains(".json"))
            file += ".json";
        
        if (!File.Exists(file))
        {
            Console.WriteLine("File does not Exist !!!");
            return;
        }

        string data = File.ReadAllText(file).Replace("    ","").Replace("\n","");
        // Console.WriteLine(data);
        string[] lines = System.IO.File.ReadAllLines(file);// data.Split(new[] {"},{"}, StringSplitOptions.RemoveEmptyEntries);
        foreach(string line in lines)
        {
            string lin = line.Replace("    ","").Replace("\n","");
            string cleaned = lin.Replace("[", "").Replace("]","").Replace("}","").Replace("{","").Trim();
            string[] sliced = cleaned.Split(",");

            Console.WriteLine(sliced[0]);
            // Console.WriteLine(sliced[1]);
            // Console.WriteLine($"\n\n{sliced[0]}");
            // Console.WriteLine($"{sliced[1]}");
            // Console.WriteLine($"{sliced[2]}\n");
        }
        // Console.WriteLine("");
    }
    public void saveJson(string file)
    {
        if (!file.Contains(".json"))
        {
            file += ".json";
        }
        if(!File.Exists(file))
            Console.WriteLine("\nFiles does not exists !!!\n");
        
        using StreamWriter writer = new StreamWriter(file);
        writer.WriteLine("[");
        for(int i=0; _entries.Count() > i; i++)
        {
            writer.WriteLine("{");
            writer.WriteLine($"      \"Prompt\": \"{_entries[i].getPrompt()}\",");
            writer.WriteLine($"      \"Entry\": \"{_entries[i].getEntryText()}\",");
            writer.WriteLine($"      \"Date\": \"{_entries[i].getDate()}\"");
            writer.WriteLine("}");
            if(!(i == _entries.Count - 1))
            {
                writer.WriteLine(",");
            }
        }
        writer.WriteLine("]");
    }
}