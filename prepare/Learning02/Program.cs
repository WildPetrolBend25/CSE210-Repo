using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        //Constructors with different arguments
        Fraction noParameters = new Fraction();
        Console.WriteLine($"No parameters: {noParameters.GetNumerator()} / {noParameters.GetDenominator()}");
        Console.WriteLine(noParameters.GetFractionString());
        Console.WriteLine(noParameters.GetDecimalValue());

        Fraction oneParameter = new Fraction(6);
        Console.WriteLine($"One parameter: {oneParameter.GetNumerator()} / {oneParameter.GetDenominator()}");
        Console.WriteLine(oneParameter.GetFractionString());
        Console.WriteLine(oneParameter.GetDecimalValue());

        Fraction twoParameters = new Fraction(6, 7);
        Console.WriteLine($"Two paramters: {twoParameters.GetNumerator()} / {twoParameters.GetDenominator()}");
        Console.WriteLine(twoParameters.GetFractionString());
        Console.WriteLine(twoParameters.GetDecimalValue());
    }
}