using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Create Goal");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Choose type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.TryParse(Console.ReadLine(), out int p) ? p : 50;

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.TryParse(Console.ReadLine(), out int t) ? t : 3;

            Console.Write("Bonus when complete: ");
            int bonus = int.TryParse(Console.ReadLine(), out int b) ? b : 200;

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void ListGoals()
    {
        Console.Clear();
        Console.WriteLine($"Total Points: {_totalPoints}\n");

        if (_goals.Count == 0)
        {
            Console.WriteLine("(no goals yet)");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        ListGoals();
        Console.Write("\nWhich goal did you accomplish? (number): ");
        if (!int.TryParse(Console.ReadLine(), out int index)) return;

        int i = index - 1;
        if (i < 0 || i >= _goals.Count) return;

        int earned = _goals[i].RecordEvent();
        _totalPoints += earned;
        Console.WriteLine($"\nYou earned {earned} points!");
        Console.WriteLine($"New total: {_totalPoints}");
    }

    public void SaveToFile()
    {
        Console.Write("File name to save (ex: goals.txt): ");
        string path = Console.ReadLine();
        using var writer = new StreamWriter(path);

        writer.WriteLine(_totalPoints);
        writer.WriteLine(_goals.Count);
        foreach (Goal g in _goals)
        {
            writer.WriteLine(g.ToSaveString());
        }

        Console.WriteLine("Saved.");
    }

    public void LoadFromFile()
    {
        Console.Write("File name to load: ");
        string path = Console.ReadLine();
        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(path);
        _totalPoints = int.Parse(lines[0]);
        int count = int.Parse(lines[1]);

        for (int i = 0; i < count; i++)
        {
            Goal g = Goal.FromSaveString(lines[2 + i]);
            _goals.Add(g);
        }

        Console.WriteLine("Loaded.");
    }
}
