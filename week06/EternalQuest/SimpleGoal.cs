public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (IsComplete) return 0;   // already done, no more points
        IsComplete = true;
        return Points;
    }
}
