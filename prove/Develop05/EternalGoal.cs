class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{name}' recorded! +{points} points");
    }

    public override string GetStatus()
    {
        return "[∞] " + name;
    }

    public override string SaveString()
    {
        return $"EternalGoal,{name},{description},{points}";
    }
}
