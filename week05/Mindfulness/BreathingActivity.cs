

class BreathingActivity : Activity
{
    
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    
    public void Run()
    {
        DisplayStaritngMessage();
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(5);
        DateTime futureDate = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < futureDate)
        {
            Console.Write("\n\nBreathe in... ");
            ShowCountDown(4);
            Console.Write("Breathe out... ");
            ShowCountDown(6);
        }
        DisplayEndingMessage();
    }
}