using System;

abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveString();

    public string GetName() { return name; }
    public int GetPoints() { return points; }
}
