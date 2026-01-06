using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is Your first name? ");
        string Fname = Console.ReadLine();
        Console.Write("What is Your last name? ");
        string Lname = Console.ReadLine();
        Console.WriteLine($"Your name is {Lname}, {Fname} {Lname}.");
        // Console.Write("Hello World! This is the Exercise1 Project.");
    }
}