

class CyclingActivity : Activity
{
    private int _speed;
    public CyclingActivity(string date,int duration): base(date, duration){}
    public CyclingActivity(string date,int duration, int speed): base(date, duration)
    {
        _speed = speed;
    }

    public override int GetDistance()
    {
        return _speed * _duration;
    }
    public override int GetSpeed(int distance=60)
    {
        return distance / GetPace();
    }
    public override int GetPace(int minutes=60)
    {
        return minutes / _speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({_duration}min)- Distance {GetDistance()}km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km";
    }
}