using System;
using System.Xml.Serialization;

class Program: Activity
{
    static int ShowMenu(string msg = "")
    {
        Console.Clear();
        Console.WriteLine(msg);
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start Breathing Activity");
        Console.WriteLine(" 2. Start Reflecting Activity");
        Console.WriteLine(" 3. Start Listing Activity");
        Console.WriteLine(" 4. Exit:");
        Console.Write("Select a choice from the menu: ");
        try
        {
            int choice = int.Parse(Console.ReadLine());
            if (choice > 4 | choice < 1)
                return ShowMenu("Please Enter a number Withing the range 0 - 4");
            return choice;
        }
        catch (System.FormatException)
        {
                return ShowMenu("Please Enter only numbers ranging from 0 - 4");
        }
    }
    static void Main(string[] args)
    {
        ListingActivity listingActivity = new ListingActivity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        int choice= ShowMenu();

        while(choice != 4)
        {
            switch (choice)
            {
                case 1:
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingActivity.Run();
                    break;
            }
            choice = ShowMenu();
        }

    }
}