public class WritingAssignment : Assignment
{
    private string _title;

    //Notice the syntax here that the WritingAssignment constructor has 3 parameters and then the base constructor has 2 parameters.
    // The base constructor is called using the ": base()" sytax.
    // The base constructor is called first, and then the GetWritingIformation constructor is called.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
     // Notice that we are calling the getter here because _studentName is private in the base class.
    string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }