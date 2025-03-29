class StudyTask
{
    private string name;
    private string subject;
    private DateTime deadline; 
    private bool isComplete;

    public StudyTask(string name, string subject)
    {
        this.name = name;
        this.subject = subject;
        this.deadline = deadline;
        this.isComplete = false;
    }

    public void MarkComplete()
    {
        isComplete = true;
    }

    public string GetTaskDetails()
    {
        string status = isComplete ? "[Done]" : "[Not Done]";
        return $"{status} {name} - {subject}";
    }
}
