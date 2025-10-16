using System;

public class Square : Shape
{
    public double Side { get; }

    public Square(double side)
        : base("Square")
    {
        Side = side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }

    public override string Describe()
    {
        return $"{Name} (side {Side}) → area {GetArea():0.##}";
    }
}
