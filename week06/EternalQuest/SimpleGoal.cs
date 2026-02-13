abstract class SimpleGoal : Goal
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
        if (_isComplete)
        {
            return $"[X] Congratulations you earned {_points} points on {_shortName} Goal.";
        }
        return $"[ ] Complete {_shortName} goal to earn {_points} points";
    }
}