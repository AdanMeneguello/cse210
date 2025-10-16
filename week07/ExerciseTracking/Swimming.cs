public class Swimming : Activity
{
    private int _laps;

    public Swimming(System.DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 1 lap = 50 meters -> km -> miles
        double meters = _laps * 50.0;
        double miles = meters / 1000.0 * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        double hours = Minutes / 60.0;
        return GetDistance() / hours;
    }

    public override double GetPace()
    {
        double miles = GetDistance();
        return miles == 0 ? 0 : Minutes / miles;
    }
}
