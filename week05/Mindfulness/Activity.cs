// I made sure no question is repeated in my reflection activity class util they are out of question.
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(){}

    public void DisplayStaritngMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        // Console.Write("\nHow long, in seconds, would you like for your session?");
        // _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell Done!!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<char> chars = new List<char>(['\\', '|', '/', '-']);
        DateTime date = DateTime.Now.AddSeconds(seconds);

        int index = 0;
        while(DateTime.Now < date)
        {
            Console.Write(chars[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            if(index == chars.Count - 1)
            {
                index = 0;
            }
            index++;
        }
    }
    public void ShowCountDown(int seconds)
    {
        DateTime date = DateTime.Now.AddSeconds(seconds);
        // Console.WriteLine(date);

        while(DateTime.Now < date)
        {
            Console.Write(seconds-1);
            Thread.Sleep(1000);
            Console.Write("\b");
            seconds -= 1;
        }
        Console.Write(" \b");
        Console.WriteLine();
    }
}