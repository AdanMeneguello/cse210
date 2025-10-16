using System;

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
        : base("Circle")
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override string Describe()
    {
        return $"{Name} (r = {Radius}) → area {GetArea():0.##}";
    }
}
