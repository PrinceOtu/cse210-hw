using System;

class Program
{
    static void Main(string[] args)
    {
        // create a base "Assignment" object
        Assignment a1 = new Assignment("Anita Baker", "Multiplication"); 
        Console.WriteLine(a1.GetSummary());

        // create the derived class assignments
        MathAssignment a2 = new MathAssignment("Raj Saini", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Jamal Jones", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}