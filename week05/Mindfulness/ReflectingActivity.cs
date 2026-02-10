

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public List<int> _picks = new List<int>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times of your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        for(int i=0; i<_questions.Count; i++)
        {
            _picks.Add(i);
        }
    }

    public void Run()
    {
        DisplayStaritngMessage();
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        

        Console.Clear();
        Console.WriteLine("Get ready... ");
        ShowSpinner(4);
        Console.WriteLine("\nConsider the following Prompt:\n");
            Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("\nPress Enter When You are ready.");
        Console.ReadLine();
        DateTime futureDate = DateTime.Now.AddSeconds(_duration);

        Console.Clear();
        while(DateTime.Now < futureDate)
        {
            Console.Write(GetRandomQuestion());
            Console.Write(' ');
            ShowSpinner(10);
            Console.WriteLine();
        }
        DisplayEndingMessage();
        ShowSpinner(4);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        // _picks.RemoveAt(index);
        return $"  -- {_prompts[index]} --";
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        
        int index = random.Next(0, _picks.Count-1);
        string ans = $"> {_questions[_picks[index]]}";
        _picks.RemoveAt(index);
        if (_picks.Count == 0)
        {
            for(int i=0; i<_questions.Count; i++)
            {
                _picks.Add(i);
            }
        }
        return ans;
    }

    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }
}