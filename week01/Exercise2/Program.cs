using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your final Grade? ");
        string sgrade = Console.ReadLine();
        float grade = float.Parse(sgrade);
        char letter = 'w';
        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else if (grade < 60)
        {
            letter = 'F';
        }
        else
        {
            letter = 'w';
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation You passed the Course");
        }
        else
        {
            Console.WriteLine("I think you should add more effort next block to be more successful.");
        }

        if (letter == 'F')
        {
            Console.WriteLine(letter);
        }
        else if(grade % 10 >= 7)
        {
            Console.WriteLine($"{letter}+");
        }
        else if(grade % 10 <= 3)
        {
            Console.WriteLine($"{letter}-");
        }
        else
        {
            Console.WriteLine(letter);
        }
    }
}