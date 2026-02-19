

abstract class Activity
{
    private string _date;
    protected int _duration = 60;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate()
    {
        return _date;
    }
    public abstract int GetDistance();
    public abstract int GetSpeed(int distance=60);
    public abstract int GetPace(int minutes=60);
    public virtual string GetSummary()
    {
        return $"{_date} {_duration}- Distance {GetDistance()}km, Speed: {GetSpeed(60)}kph, Pace: {GetPace(60)} min per km";
    }

}