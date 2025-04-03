using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (true)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                break;
            }
            numbers.Add(input);
        }

        // Core Requirements
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge
        int? smallestPositive = numbers.Where(n => n > 0).OrderBy(n => n).FirstOrDefault();
        List<int> sortedList = numbers.OrderBy(n => n).ToList();

        if (smallestPositive.HasValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive.Value}");
        }
        else
        {
            Console.WriteLine("There is no positive number in the list.");
        }

        Console.WriteLine("The sorted list is:");
        foreach (int num in sortedList)
        {
            Console.WriteLine(num);
        }
    }
}