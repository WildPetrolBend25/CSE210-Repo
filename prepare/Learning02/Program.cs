using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        //Constructors with different arguments
        Fraction noParameters = new Fraction();
        Fraction oneParameter = new Fraction(6);
        Fraction twoParameters = new Fraction(6, 7);

        Console.WriteLine($"No parameters: { noParameters.GetNumerator()} / { noParameters.GetDenominator()}");
        Console.WriteLine($"One parameter: { oneParameter.GetNumerator()} / {oneParameter.GetDenominator()}");
        Console.WriteLine($"Two paramters: {twoParameters.GetNumerator()} / {twoParameters.GetDenominator()}");
    }
}