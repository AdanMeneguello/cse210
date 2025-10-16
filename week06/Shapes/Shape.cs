using System;

public abstract class Shape
{
    public string Name { get; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract double GetArea();

    public virtual string Describe()
    {
        return $"{Name} with area {GetArea():0.##}";
    }
}
