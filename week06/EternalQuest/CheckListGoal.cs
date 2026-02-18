class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string descrition, string points, int target, int bonus, int amountCompleted = 0): base(name, descrition, points)
    {
        _shortName = name;
        _description = descrition;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        // _points = $"{int.Parse(_points) * _target}";
        // if (IsComplete())
        // {
        //     // _points = $"{int.Parse(_points) + _bonus}";
        // }
        Console.WriteLine(GetDetailsString());
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else return false;
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}