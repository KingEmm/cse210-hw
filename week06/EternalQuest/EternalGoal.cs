class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points): base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    

    public override void RecordEvent()
    {
        Console.WriteLine(GetDetailsString());
    }
    public override bool IsComplete()
    {
        return int.Parse(_points) >=  int.Parse(_points)*2;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName} | {_description} | {_points}";
    }
}