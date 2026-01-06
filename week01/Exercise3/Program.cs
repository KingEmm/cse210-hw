using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int  majiknum = rand.Next(1,101);
        int num = 0 , count = 0;
        string answer = "yes";

        do
        {
            Console.Write("Guess the magic Number : ");
            string number = Console.ReadLine();
            num = int.Parse(number);
            if (majiknum == num)
            {
                Console.WriteLine($"You guessed it with {count} tries !!!\n");
                Console.Write("Will you like to play again (yes / no)? ");
                answer = Console.ReadLine();
                // rand = new Random();
                majiknum = rand.Next(1,11);
                count = 0;
            }
            else
            {
                if (num > majiknum)
                {
                    Console.WriteLine("Lower");
                }else
                {
                    Console.WriteLine("Higher");
                }
            }
            count++;
        }
        while(answer != "no");
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");
    }
}