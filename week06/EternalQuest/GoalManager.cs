class GoalManager
{
    private List<Goal> _goal;
    private int _score;
    public GoalManager(){}

    public void Start(){}
    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }
    public void ListGoalNames()
    {
        
        foreach(Goal goal in _goal)
        {
            string str = goal.GetStringRepresentation().Split(':')[1].Split('|')[0];
            Console.WriteLine($"{_goal.IndexOf(goal)}. {str}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goal)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        // ListGoalNames();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("What is the name of your Goal? ");
                string name = Console.ReadLine();
                Console.Write("Give a short description for your Goal? ");
                string description = Console.ReadLine();
                Console.Write("How many points will you like to allocate for this goal? ");
                string points = Console.ReadLine();

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goal.Add(simpleGoal);
                break;

            case 2:
                Console.Write("What is the name of your Goal? ");
                string eternalName = Console.ReadLine();
                Console.Write("Give a short description for your Goal? ");
                string eternalDescription = Console.ReadLine();
                Console.Write("How many points will you like to allocate for this goal? ");
                string eternalPoints = Console.ReadLine();

                EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                _goal.Add(eternalGoal);
                break;

            case 3:
                Console.Write("What is the name of your Goal? ");
                string checklistName = Console.ReadLine();
                Console.Write("Give a short description for your Goal? ");
                string checklistDescription = Console.ReadLine();
                Console.Write("How many points will you like to allocate for this goal? ");
                string checklistPoints = Console.ReadLine();
                Console.Write("How many times will you like to repeat this goal? ");
                int checklistTarget = int.Parse(Console.ReadLine());
                Console.Write("Give a bonus for this goal when completed? ");
                int checklistBonus = int.Parse(Console.ReadLine());

                CheckListGoal checklistGoal = new CheckListGoal(checklistName, checklistDescription, checklistPoints, checklistTarget, checklistBonus);
                _goal.Add(checklistGoal);
                break;

            default:
                Console.WriteLine("Invalid Entry!!!");
                break;
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which Goal did you accomplish? ");
        int chioce = int.Parse(Console.ReadLine());
        if (chioce >= _goal.Count | chioce < 1)
        {
            Console.WriteLine("Invalid Selection");
        }
        else
        {
            _goal[chioce].RecordEvent();
            // _score += _goal[chioce]
        }
    }
    public void SaveGoals(){}
    public void LoadGoals(){}
}