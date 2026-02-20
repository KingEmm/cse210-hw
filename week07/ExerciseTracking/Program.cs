using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity("19 Feb 2026", 30, 3)); 
        activities.Add(new CyclingActivity("19 Feb 2026", 30, 10)); 
        activities.Add(new SwimmingActivity("19 Feb 2026", 30, 4));

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    }
}