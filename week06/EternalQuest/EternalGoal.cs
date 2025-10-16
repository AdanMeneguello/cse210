public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        // never completes; always gives base points
        return Points;
    }

    public override string GetDetailsString()
    {
        // Always open
        return $"[ ] {Name} ({Description}) — (eternal)";
    }
}
