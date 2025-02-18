
public class MathAssignment : Assignment
{
    private string _homeworkList;

    // Constructor to initialize student name, topic, and homework list
    public MathAssignment(string studentName, string topic, string homeworkList)
        : base(studentName, topic)
    {
        _homeworkList = homeworkList;
    }

    // Method to get the homework list
    public string GetHomeworkList()
    {
        return _homeworkList;
    }
}
