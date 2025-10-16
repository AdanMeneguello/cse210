using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string Name => _name;
    public string Description => _description;
    protected int Points => _points;

    public bool IsComplete
    {
        get => _isComplete;
        protected set => _isComplete = value;
    }

    // Polymorphism: each derived class defines how it records an event and how many points it gives.
    public abstract int RecordEvent();

    // Default details string; derived classes may override.
    public virtual string GetDetailsString()
    {
        string done = _isComplete ? "X" : " ";
        return $"[{done}] {_name} ({_description})";
    }

    // Serialization helpers (save/load)
    public virtual string ToSaveString()
    {
        // type|name|desc|points|isComplete
        return $"{GetType().Name}|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public static Goal FromSaveString(string line)
    {
        // Expected formats per Goal type
        // SimpleGoal|name|desc|points|isComplete
        // EternalGoal|name|desc|points|isComplete
        // ChecklistGoal|name|desc|points|isComplete|current|target|bonus
        string[] parts = line.Split('|');
        string type = parts[0];
        string name = parts[1];
        string desc = parts[2];
        int points = int.Parse(parts[3]);
        bool isComplete = bool.Parse(parts[4]);

        if (type == nameof(SimpleGoal))
        {
            var g = new SimpleGoal(name, desc, points);
            g.IsComplete = isComplete;
            return g;
        }
        else if (type == nameof(EternalGoal))
        {
            var g = new EternalGoal(name, desc, points);
            // Eternal goals never complete; ignore isComplete
            return g;
        }
        else if (type == nameof(ChecklistGoal))
        {
            int current = int.Parse(parts[5]);
            int target = int.Parse(parts[6]);
            int bonus = int.Parse(parts[7]);
            var g = new ChecklistGoal(name, desc, points, target, bonus);
            g.SetProgress(current, isComplete);
            return g;
        }

        throw new InvalidOperationException("Unknown goal type");
    }
}
