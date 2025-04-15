
// a parent class called Person
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

// a child class called Student
public class Student : Person
{
    private string _number;

    // calling the parent constructor using "base"!
    public Student(string name, string number) : base(name)
    {
      _number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
}


Student student = new Student("Brigham", "234");
string name = student.GetName();
string number = student.GetNumber();
Console.WriteLine(name);
Console.WriteLine(number);

string number = base.GetName();
Console.WriteLine($"Student Number: {number}");
