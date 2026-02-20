

class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(){}// base(date, duration){}
    public SwimmingActivity(string date,int duration): base(date, duration){}
    public SwimmingActivity(string date,int duration, int laps): base(date, duration)
    {
        _laps = laps;
    }
    public override float GetDistance()
    {
        float meters = _laps * 50;
        return meters / 1000;
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
        return $"{GetDate()} Swimming ({_duration}mins)- Distance {GetDistance()}km, Speed: {GetSpeed(GetDistance())}kph, Pace: {GetPace(_duration)} min per km";
    }
}