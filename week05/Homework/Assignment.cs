public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // We will use this method in the derived classes to get the student name.
    // alternatively, you can make _studentName protected in the base class.
    //     public string GetSummary()
    public string GetStudentName()
    {
        return _studentName;

    }
    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}