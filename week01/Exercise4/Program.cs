using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, enter 0 to finish.");

        int number = -1;
        while (number != 0)
        {
            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        //total sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        //Avarege
        double avr = (double)sum / numbers.Count;

        int higher = numbers[0];
        foreach (int n in numbers)
        {
            if (n > higher)
            {
                higher = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avr}");
        Console.WriteLine($"The higher number is: {higher}");

    }
}