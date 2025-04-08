using System;

public class ChecklistTask : Task
{
    private int _targetCount;
    private int _currentCount;

    public ChecklistTask(string title, string description, int targetCount)
        : base(title, description)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine("Checklist progress for " + _title + ": " + _currentCount + "/" + _targetCount);
            if (_currentCount == _targetCount)
            {
                _isComplete = true;
                Console.WriteLine("Checklist task completed: " + _title);
            }
        }
        else
        {
            Console.WriteLine("Checklist task already completed: " + _title);
        }
    }

    public override string GetStatus()
    {
        return "[Checklist] " + _title + " - " + _description + " (" + _currentCount + "/" + _targetCount + ")";
    }
}
