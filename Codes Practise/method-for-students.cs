
public class Student : Person
{
    private string _number;

    ...

    public string GetStudentInfo()
    {
        // ERROR! This line doesn't work, because _name is private in the base class
        return _name + " " + _number;
    }
}


public class Person
{
    private string _name;

    public Person(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    }

public class Student : Person 
{
    private string _number;

    // calling the parent constructor using "base"!
    public Student(string name, string number) : base(name)
    {
        _number = number;
    }
    }