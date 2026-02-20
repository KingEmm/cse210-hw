

class RunningActivity : Activity
{
    // public int distance;
    private int _distance;

    public RunningActivity(string date,int duration): base(date, duration){}
    public RunningActivity(string date,int duration, int speed): base(date, duration)
    {
        _distance = speed;
    }
    public override int GetDistance()
    {
        return _distance;
    }
    public override int GetSpeed(int distance=60)
    {
        return (distance / _duration) *60;
    }
    public override int GetPace(int minutes=60)
    {
        return minutes / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({_duration}min)- Distance {GetDistance()}km, Speed: {GetSpeed(GetDistance())}kph, Pace: {GetPace(_duration)} min per km";
    }
}