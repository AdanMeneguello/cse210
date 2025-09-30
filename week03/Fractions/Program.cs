using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Week 03 – Encapsulation: Fraction ===\n");

        // (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine("f1 (default):");
        Console.WriteLine($"String: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");
        Console.WriteLine();

        // (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine("f2 (top=5):");
        Console.WriteLine($"String: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal: {f2.GetDecimalValue()}");
        Console.WriteLine();

        // (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine("f3 (3/4):");
        Console.WriteLine($"String: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal: {f3.GetDecimalValue()}");
        Console.WriteLine();

        // (7/8)
        f3.SetTop(7);
        f3.SetBottom(8);
        Console.WriteLine("f3 changed to 7/8 via setters:");
        Console.WriteLine($"String: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal: {f3.GetDecimalValue()}");
        Console.WriteLine();

        // Validation test (denominator 0)
        Fraction f4 = new Fraction(10, 0);
        Console.WriteLine("f4 trying to create 10/0 (adjusted to 10/1):");
        Console.WriteLine($"String: {f4.GetFractionString()}");
        Console.WriteLine($"Decimal: {f4.GetDecimalValue()}");
        Console.WriteLine();

        Console.WriteLine("Done! Encapsulation applied (private fields + getters/setters).");
    }
}
