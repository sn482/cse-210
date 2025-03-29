using System;

abstract class Task
{
    protected string name;
    protected string description;
    protected bool isComplete;

    public Task(string name, string description)
    {
        this.name = name;
        this.description = description;
        isComplete = false;
    }

    public abstract void RecordEvent();

    public virtual string GetStatus()
    {
        return (isComplete ? "[X] " : "[ ] ") + name + " - " + description;
    }
}
