using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the Fraction class

        // Creating fractions using different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(3, 4);

        // Displaying fraction representations
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} - Decimal: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} - Decimal: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} - Decimal: {fraction3.GetDecimalValue()}");

        // Using getters and setters
        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()} - Decimal: {fraction3.GetDecimalValue()}");
    }
}