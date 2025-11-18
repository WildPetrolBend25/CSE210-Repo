using System;

class Program
{
    static void Main(string[] args)
    {
        //test code
        Console.WriteLine("Hello Learning04 World!");

        //instances
        Assignments myAssignment = new Assignments("Billy Jones", "fractions");
        MathAssignment myMathAssignment = new MathAssignment("Joseph Smith", "Fractions", "7.3", "8-19");
        
        //call methods
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
    }
}