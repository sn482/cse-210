using System;

public abstract class Task
{
    protected string _title;
    protected string _description;
    protected bool _isComplete;

    public Task(string title, string description)
    {
        _title = title;
        _description = description;
        _isComplete = false;
    }

    public abstract void RecordEvent();

    public virtual string GetStatus()
    {
        return (_isComplete ? "[X] " : "[ ] ") + _title + " - " + _description;
    }
}

