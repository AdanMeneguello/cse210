using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var shapes = new List<Shape>
        {
            new Rectangle(3, 4),
            new Square(5),
            new Circle(2.5),
            new Rectangle(10, 2)
        };

        Console.WriteLine("Polymorphism demo: same call, different results\n");

        double total = 0;
        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.Describe());
            total += s.GetArea();
        }

        Console.WriteLine($"\nTotal area = {total:0.##}");
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
