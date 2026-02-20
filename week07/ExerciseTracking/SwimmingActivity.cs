

class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date,int duration): base(date, duration){}
    public SwimmingActivity(string date,int duration, int laps): base(date, duration)
    {
        _laps = laps;
    }
    public override int GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override int GetSpeed(int distance=60)
    {
        return (distance / _duration) * 60;
    }
    public override int GetPace(int minutes=60)
    {
        return minutes / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({_duration}mins)- Distance {GetDistance()}km, Speed: {GetSpeed(GetDistance())}kph, Pace: {GetPace(_duration)} min per km";
    }
}