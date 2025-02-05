using System;

class Program
{
    static void Main()
    {
        // Testing different constructors
        Fraction frac1 = new Fraction();        // 1/1
        Fraction frac2 = new Fraction(5);       // 5/1
        Fraction frac3 = new Fraction(3, 4);    // 3/4
        Fraction frac4 = new Fraction(1, 3);    // 1/3

        // Display fraction and decimal values
        Console.WriteLine(frac1.GetFractionString()); // 1/1
        Console.WriteLine(frac1.GetDecimalValue());   // 1.0

        Console.WriteLine(frac2.GetFractionString()); // 5/1
        Console.WriteLine(frac2.GetDecimalValue());   // 5.0

        Console.WriteLine(frac3.GetFractionString()); // 3/4
        Console.WriteLine(frac3.GetDecimalValue());   // 0.75

        Console.WriteLine(frac4.GetFractionString()); // 1/3
        Console.WriteLine(frac4.GetDecimalValue());   // 0.3333...

        // Testing getters and setters
        Fraction testFraction = new Fraction(2, 5);   // 2/5
        Console.WriteLine(testFraction.GetFractionString()); // 2/5

        testFraction.SetNumerator(7);
        testFraction.SetDenominator(8);
        Console.WriteLine(testFraction.GetFractionString()); // 7/8
        Console.WriteLine(testFraction.GetDecimalValue());   // 0.875
    }
}
