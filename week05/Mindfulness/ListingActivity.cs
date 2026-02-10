class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes? ");
    }

    public void Run()
    {
        DisplayStaritngMessage();
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("\nList as many response as you can to the following prompt.");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine($"You Listed {_count} items.\n");
        // Console.WriteLine($"WELL DONE!!\n");

        ShowSpinner(5);
        DisplayEndingMessage();
        // ShowSpinner(5);
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        // _picks.RemoveAt(index);
        return $"  -- {_prompts[index]} --";
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();
        DateTime futureDate = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < futureDate)
        {
            Console.Write("> ");
            string text = Console.ReadLine();
            answers.Add(text);
            _count++;
        }
        return answers;
    }
}