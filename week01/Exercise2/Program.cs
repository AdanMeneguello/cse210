using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int percent))
        {
            Console.WriteLine("Please enter a valid integer percentage (e.g., 83).");
            return;
        }

        string letter;
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You'll do better next time.");
        }


        string sign = "";
        int lastDigit = percent % 10;

        if (lastDigit >= 7) sign = "+";
        else if (lastDigit < 3) sign = "-";

        if (letter == "A" && sign == "+")
        {
            sign = ""; 
        }
        if (letter == "F")
        {
            sign = ""; 
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}
