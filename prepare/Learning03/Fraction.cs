using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Default constructor (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor for whole numbers (x/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor for fractions (x/y)
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for Numerator (Top)
    public int GetNumerator() { return _top; }
    public void SetNumerator(int value) { _top = value; }

    // Getter and Setter for Denominator (Bottom)
    public int GetDenominator() { return _bottom; }
    public void SetDenominator(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _bottom = value;
    }

    // Returns fraction as a string "a/b"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
