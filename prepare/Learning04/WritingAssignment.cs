
public class WritingAssignment : Assignment
{
    private string _writingInformation;

    // Constructor to initialize student name, topic, and writing information
    public WritingAssignment(string studentName, string topic, string writingInformation)
        : base(studentName, topic)
    {
        _writingInformation = writingInformation;
    }

    // Method to get the writing information
    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - {_writingInformation}";
    }

    // Method to access student name from base class (since it's private)
    private string GetStudentName()
    {
        return base.GetSummary().Split(" - ")[0]; // Extract the student name from the summary
    }
}
