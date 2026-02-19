using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Append(new RunningActivity("19 Feb 2026", 30)); 
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    }
}