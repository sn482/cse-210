class SimpleTask : Task
{
    public SimpleTask(string name, string description)
        : base(name, description) { }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine("Task completed: " + _title);
        }
        else
        {
            Console.WriteLine("Task already completed.");
        }
    }
}
