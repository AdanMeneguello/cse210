using System;

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
        : base("Rectangle")
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override string Describe()
    {
        return $"{Name} ({Width} x {Height}) → area {GetArea():0.##}";
    }
}
