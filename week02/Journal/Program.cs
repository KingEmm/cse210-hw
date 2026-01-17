using System;

class Program
{

    static void ShowMenuOption()
    {
        Console.WriteLine("0 Exit Program ");
        Console.WriteLine("1 Write a new entry: ");
        Console.WriteLine("2 Display the journal: ");
        Console.WriteLine("3 Save the journal to a file: ");
        Console.WriteLine("4 Load the journal from a file: ");
        Console.WriteLine("5 Save the journal to a JSON file: ");
        Console.WriteLine("6 Load the journal from a JSON file: ");
        Console.Write("Select an Option option from those listed above : ");
    }
    static int GetMenuOption(){
        try
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice){
            case 0:
                return 0;
            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 3;
            case 4:
                return 4;
            case 5:
                return 5;
            case 6:
                return 6;
            default :   
                return GetMenuOption();
        }
        }
        catch (System.FormatException)
        {
            Console.Write("Invalid Input Please Select option form a given range of 0 - 6 > ");
            return GetMenuOption();
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Daily Journal \n");
        Journal journal = new Journal();
        bool ans = true;
        while (ans)
        {
            Entry entity = new Entry();
            ShowMenuOption();
            int choice = GetMenuOption();
            switch (choice)
            {
                case 0:
                    ans = false;
                    break;
                case 1:
                    // char ques = 'y';
                    //     Console.Write("Would you like to get a prompt question to respond to? ");
                    // ques = char.Parse(Console.ReadLine());
                    // if(ques == 'y')
                    // {
                        entity.Display();
                    // }
                    // else
                    // {
                    //     Console.Write("Start entring > ");
                    //     string data = Console.ReadLine();
                    //     entity.SetAllEntry(data);
                    // }
                    // Console.WriteLine($"{entity.getPrompt()} \n{entity.getEntryText()} \n{entity.getDate()}");
                    journal.AddEntry(entity);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("Enter File Name: ");
                    string fileName = Console.ReadLine();
                    journal.SaveToFile($"{fileName}");
                    break;
                case 4:
                    Console.Write("Enter File Name: ");
                    string FileName = Console.ReadLine();
                    journal.LoadFile($"{FileName}");
                    break;
                case 5:
                    Console.Write("Enter File Name: ");
                    string jsonFileName = Console.ReadLine();
                    journal.saveJson($"{jsonFileName}");
                    break;
                case 6:
                    Console.Write("Enter File Name: ");
                    string jsonfileName = Console.ReadLine();
                    journal.loadJson($"{jsonfileName}");
                    break;
                default :   
                    break;
            }
        }
       
        // Entry ent = new Entry();
        // ent.Display();
        // Console.WriteLine(PromptGenerator.GetRandomPrompt());
    }
}