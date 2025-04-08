using System;

public class EternalTask : Task
{
    private int _count;

    public EternalTask(string title, string description)
        : base(title, description)
    {
        _count = 0;
    }

    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine("Eternal task event recorded for " + _title + " (Count: " + _count + ")");
    }

    public override string GetStatus()
    {
        return "[Eternal] " + _title + " - " + _description + " (Count: " + _count + ")";
    }
}
