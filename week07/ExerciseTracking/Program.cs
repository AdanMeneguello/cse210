using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2024, 11, 4), 40, 18.0),
            new Swimming(new DateTime(2024, 11, 5), 25, 30)
        };

        foreach (var a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
