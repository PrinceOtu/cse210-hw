
public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }

    ...
}
// Compare this snippet from Codes%20Practise/Method.cs:
// public class Person
// {
//     private string _title;
//     private string _firstName;}
//     private string _lastName;//
//
//     public string GetInformalSignature()
//     {
//         return "Thanks, " + _firstName;
//     }

{
    
Person p = new Person();
p.SetFirstName("Peter");

Console.WriteLine(p.GetFirstName());
}