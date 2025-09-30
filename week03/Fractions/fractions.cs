using System;

public class Fraction
{

    private int _top;     
    private int _bottom;  

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        SetBottom(bottom);
    }

    // GETTERS e SETTERS
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            Console.WriteLine("Warning: denominator 0 is not allowed. Adjusting to 1.");
            _bottom = 1;
        }
        else
        {
            _bottom = bottom;
        }
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
