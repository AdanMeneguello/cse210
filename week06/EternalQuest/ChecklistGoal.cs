public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (IsComplete) return 0;

        _currentCount++;

        int earned = Points;

        if (_currentCount >= _targetCount)
        {
            IsComplete = true;
            earned += _bonus;
        }

        return earned;
    }

    public override string GetDetailsString()
    {
        string done = IsComplete ? "X" : " ";
        return $"[{done}] {Name} ({Description}) -- progress: {_currentCount}/{_targetCount}, bonus: {_bonus}";
    }

    public void SetProgress(int current, bool complete)
    {
        _currentCount = current;
        IsComplete = complete;
    }

    public override string ToSaveString()
    {
        // ChecklistGoal | name | desc | points | isComplete | current | target | bonus
        return $"{GetType().Name}|{Name}|{Description}|{Points}|{IsComplete}|{_currentCount}|{_targetCount}|{_bonus}";
    }
}
