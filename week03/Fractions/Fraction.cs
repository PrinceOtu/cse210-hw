using System;

public class Fraction
{
    // Private attributes for numerator and denominator
    private int numerator;
    private int denominator;

    // Constructor with no parameters, initializes to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter (numerator), denominator defaults to 1
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

    // Constructor with two parameters (numerator and denominator)
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator != 0 ? denominator : throw new ArgumentException("Denominator cannot be zero.");
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator
    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            this.denominator = denominator;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Method to get fraction string representation
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}