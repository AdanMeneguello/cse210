using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    // miles, mph, min/mile
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string when = _date.ToString("dd MMM yyyy");
        return $"{when} {GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.##} miles, " +
               $"Speed {GetSpeed():0.##} mph, " +
               $"Pace {GetPace():0.##} min per mile";
    }
}
