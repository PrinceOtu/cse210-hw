public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

// Notice the constructor is similar to the base class constructor, but it also takes two additional parameters.
// The base constructor is called using the ": base()" syntax.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables.
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}