public class Running : Activity
{
    private double _miles;

    public Running(System.DateTime date, int minutes, double miles)
        : base(date, minutes)
    {
        _miles = miles;
    }

    public override double GetDistance() => _miles;

    public override double GetSpeed()
    {
        double hours = Minutes / 60.0;
        return _miles / hours;
    }

    public override double GetPace()
    {
        return Minutes / _miles;
    }
}
