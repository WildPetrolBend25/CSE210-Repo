using System;

public class Fraction
{
    private int _topNumber = 0;
    private int _bottomNumber = 0;

    //no argument constructor
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }
    public Fraction(int numerator)
    {
        _topNumber = numerator;
        _bottomNumber = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _topNumber = numerator;
        _bottomNumber = denominator;
    }

    //Getter for numerator
    public int GetNumerator()
    {
        return _topNumber;
    }

    //getter for denominator
    public int GetDenominator()
    {
        return _bottomNumber;
    }

    //setter for numerator
    public void SetNumerator(int number)
    {
        _topNumber = number;
    }

    //setter for the denominator
    public void SetDenominator(int number)
    {
        _bottomNumber = number;
    }
}