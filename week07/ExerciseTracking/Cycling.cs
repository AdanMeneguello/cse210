public class Cycling : Activity
{
    private double _mph;

    public Cycling(System.DateTime date, int minutes, double mph)
        : base(date, minutes)
    {
        _mph = mph;
    }

    public override double GetDistance()
    {
        double hours = Minutes / 60.0;
        return _mph * hours;
    }

    public override double GetSpeed() => _mph;

    public override double GetPace()
    {
        return 60.0 / _mph;
    }
}
