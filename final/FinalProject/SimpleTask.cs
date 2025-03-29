class SimpleTask : Task
{
    public SimpleTask(string name, string description)
        : base(name, description) { }

    public override void RecordEvent()
    {
        if (!isComplete)
        {
            isComplete = true;
            Console.WriteLine("Task completed: " + name);
        }
        else
        {
            Console.WriteLine("Task already completed.");
        }
    }
}
