using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string number = Console.ReadLine();
        return int.Parse(number);
    }
    static int SquareNumber(int num)
    {
        return num * num;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        Console.WriteLine($"{name}, the square of your favorite number is {SquareNumber(userNumber)}");
    }
}