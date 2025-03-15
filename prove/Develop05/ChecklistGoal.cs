class ChecklistGoal : Goal
{
    private int currentCount;
    private int requiredCount;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints) 
        : base(name, description, points)
    {
        this.requiredCount = requiredCount;
        this.bonusPoints = bonusPoints;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (currentCount < requiredCount)
        {
            currentCount++;
            Console.WriteLine($" Progress on '{name}': {currentCount}/{requiredCount} (+{points} points)");
            if (currentCount == requiredCount)
            {
                Console.WriteLine($"Goal '{name}' completed! Bonus: +{bonusPoints} points");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{name}' already completed.");
        }
    }

    public override string GetStatus()
    {
        return $"[{(currentCount == requiredCount ? "X" : " ")}] {name} - {currentCount}/{requiredCount} times completed";
    }

    public override string SaveString()
    {
        return $"ChecklistGoal,{name},{description},{points},{currentCount},{requiredCount},{bonusPoints}";
    }
}
