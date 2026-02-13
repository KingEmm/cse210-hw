abstract class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string descrition, string points, int target, int bonus): base(name, descrition, points)
    {
        _shortName = name;
        _description = descrition;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    public override abstract void RecordEvent();
    public override abstract bool IsComplete();
    public override abstract string GetDetailsString();
    public override abstract string GetStringRepresentation();
}