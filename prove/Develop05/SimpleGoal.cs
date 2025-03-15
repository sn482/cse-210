class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        isCompleted = false;
    }

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            Console.WriteLine($" Goal '{name}' completed! +{points} points");
        }
        else
        {
            Console.WriteLine($"Goal '{name}' is already completed.");
        }
    }

    public override string GetStatus()
    {
        return isCompleted ? "[X] " + name : "[ ] " + name;
    }

    public override string SaveString()
    {
        return $"SimpleGoal,{name},{description},{points},{isCompleted}";
    }
}
