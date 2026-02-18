class GoalManager
{
    private List<Goal> _goal = new List<Goal>();
    private int _score;
    public GoalManager(){}

    public void Start()
    {
        int choice = 0;
        while(choice != 6)
        {
            Console.WriteLine($"\nScore : {_score}\n");
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create New Goals");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                
                case 3:
                    SaveGoals();
                    break;
                
                case 4:
                    LoadGoals();
                    break;
                
                case 5:
                    RecordEvent();
                    break;

                case 6:
                    break;

                default:
                    Console.WriteLine("Invalid input selection");
                    break;
                
            }
                
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine(_score);
    }
    public void ListGoalNames()
    {
        
        foreach(Goal goal in _goal)
        {
            string str = goal.GetStringRepresentation().Split(':')[1].Split('|')[0];
            Console.WriteLine($"{_goal.IndexOf(goal)+1}. {str}");
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
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");

        Console.Write("Which goal type from option above: ");
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
        if (_goal.Count == 0)
        {
            Console.WriteLine("\n!!! You do not have a goal try creating one !!!");
            return;
        }
        ListGoalNames();
        Console.Write("Which Goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice > _goal.Count | choice < 1)
        {
            Console.WriteLine("Invalid Selection");
        }
        else
        {
            _goal[choice-1].RecordEvent();
            _score += _goal[choice-1].GetPoint();
            if(_goal[choice-1].GetType().ToString() == "CheckListGoal")
            {
                if (_goal[choice-1].IsComplete())
                {
                    var bonus = _goal[choice-1].GetStringRepresentation().Split(':')[1].Split('|')[3].TrimStart().TrimEnd();
                    Console.Write(bonus);
                    _score += int.Parse(bonus);
                }
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter file name: ");
        string fileName  = Console.ReadLine();

        using(StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach(Goal goal in _goal)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("Enter file name: ");
        string fileName  = Console.ReadLine();

        string [] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        for(int i = 1; i < lines.Count(); i++)
        {
            string type = lines[i].Split(':')[0];
            Console.WriteLine(type);
            string[] infos = lines[i].Split(':')[1].Split('|');
            if(type == "SimpleGoal")
            {
                _goal.Add(new SimpleGoal(infos[0], infos[1], infos[2], bool.Parse(infos[3])));
            }
            else if(type == "EternalGoal")
            {
                _goal.Add(new EternalGoal(infos[0], infos[1], infos[2]));
            }
            else if(type == "CheckListGoal")
            {
                _goal.Add(new CheckListGoal(infos[0], infos[1], infos[2], int.Parse(infos[4]), int.Parse(infos[3]), int.Parse(infos[5])));
            }
            else
            {
                Console.WriteLine("Invalid Type");
            }
        }
        
    }
}