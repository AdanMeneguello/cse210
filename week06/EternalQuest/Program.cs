using System;

public class Program
{
    public static void Main()
    {
        var manager = new GoalManager();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1") manager.CreateGoal();
            else if (choice == "2") manager.ListGoals();
            else if (choice == "3") manager.RecordEvent();
            else if (choice == "4") manager.SaveToFile();
            else if (choice == "5") manager.LoadFromFile();
            else if (choice == "6") break;
            else Console.WriteLine("Invalid option.");
        }

        Console.WriteLine("Goodbye!");
    }
}
