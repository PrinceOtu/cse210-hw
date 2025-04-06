Person p = new Person(); // This calls a no-argument constructor and doesn't need any information
public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }

    ...

}
// This is a no-argument constructor. It doesn't take any parameters annd initializes the object with default values.
// This is useful when you want to create an object without providing any iformation at the time of creation.
// The constructor is called when you create an object of the class. It sets the initial state of the object.
// The constructor is a special method that is called when an object of the class is created. It has the same name as the class and doesn't have a return type.
// The constructor can take parameters, but in this case, it doesn't. It initializes the object with default values.

{
    
public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }

    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }

    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }
    ...

}
// This is a no-argument constructor. It doesn't take any parameters and initializes the object with default values.
// This is useful when you want to create an object without providing any information at the time of creation.
// The constructor is called when you create an object of the class. It sets the initial state of the object.
// The constructor is a special method that is called when an object of the class is craeted. It has the same name as the class and doesn't have a return type.
// The constructor can take parameters, but in this case, it doesn't. It initializes the object with default values.
{

}
}
// These three constructors allow you to create a new person object in any of those three ways:

{
    Person p1 = new Person(); // Don't pass any information to get the default values
Person p2 = new Person("Jane", "Doe"); // pass the first and last names
Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables
}
