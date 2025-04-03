using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign for stretch challenge
        string sign = "";
        if (letter != "A" && letter != "F") // Only grades B, C, D may have signs
        {
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Combine letter and sign
        string finalGrade = letter + sign;

        // Print the letter grade
        Console.WriteLine($"Your grade is: {finalGrade}");

        // Check if the user passed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Try harder next time.");
        }
    }
}