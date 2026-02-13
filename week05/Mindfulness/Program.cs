// I made sure no question is repeated in my reflection activity class util they are out of question.

using System;
using System.Xml.Serialization;

class Program
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
        ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times of your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

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