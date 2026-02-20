

class CyclingActivity : Activity
{
    private int _speed;
    public CyclingActivity(){}
    public CyclingActivity(string date,int duration): base(date, duration){}
    public CyclingActivity(string date,int duration, int speed): base(date, duration)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return GetSpeed(_speed) * _duration;
    }
    public override float GetSpeed(float speed=60)
    {
        return speed;
    }
    public override float GetPace(float minutes=60)
    {
        return minutes / GetSpeed(_speed);
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({_duration}min)- Distance {GetDistance()}km, Speed: {GetSpeed(_speed)}kph, Pace: {GetPace(_duration)} min per km";
    }
}