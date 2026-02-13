abstract class EternalGoal : Goal
{
    public EternalGoal(string name, string descrition, string points): base(name, descrition, points)
    {
        _shortName = name;
        _description = descrition;
        _points = points;
    }
    

    public override abstract void RecordEvent();
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return _isComplete;
        }
        return _isComplete;
    }
    public override abstract string GetDetailsString();
    public override abstract string GetStringRepresentation();
}