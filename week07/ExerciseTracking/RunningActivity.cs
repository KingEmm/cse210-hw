

class RunningActivity : Activity
{
    // public int distance;
    private float _distance;

    public RunningActivity(){}
    public RunningActivity(string date,int duration): base(date, duration){}
    public RunningActivity(string date,int duration, float speed): base(date, duration)
    {
        _distance = speed;
    }
    public override float GetDistance()
    {
        return _distance;
    }
    public override float GetSpeed(float distance=60)
    {
        return distance / _duration * 60;
    }
    public override float GetPace(float minutes=60)
    {
        return minutes / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({_duration}min)- Distance {GetDistance()}km, Speed: {GetSpeed(GetDistance())}kph, Pace: {GetPace(_duration)} min per km";
    }
}