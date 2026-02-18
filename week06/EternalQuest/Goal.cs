abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string name, string descrition, string points)
    {
        _shortName = name;
        _description = descrition;
        _points = points;
    }
    public int GetPoint()
    {
        return int.Parse(_points);
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
         if (IsComplete())
        {
            return $"[X] Congratulations you earned {_points} points on {_shortName} Goal.";
        }
        return $"[ ] {_shortName} ({_description}) ";
    }
    public abstract string GetStringRepresentation();
}