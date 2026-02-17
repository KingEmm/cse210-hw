class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string descrition, string points): base(name, descrition, points)
    {
        _shortName = name;
        _description = descrition;
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete=true;
        Console.WriteLine(GetDetailsString());
    }

    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return _isComplete;
        }
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName} | {_description} | {_points} | {IsComplete()}";
    }
}