
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor to initialize the student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to get the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
