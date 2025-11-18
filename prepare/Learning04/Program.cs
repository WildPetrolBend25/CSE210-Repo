using System;

class Program
{
    static void Main(string[] args)
    {
        //test code
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("\n");

        //instances
        Assignments myAssignment = new Assignments("Billy Jones", "fractions");
        MathAssignment myMathAssignment = new MathAssignment("Joseph Smith", "Fractions", "7.3", "8-19");
        WritingAssignment myWritingAssignment = new WritingAssignment("Willam Edwards", "WWII History", "Famous WWII Tanks");
        
        //call methods
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine("\n");

        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        Console.WriteLine("\n");

        
        Console.WriteLine(myWritingAssignment.GetSummary());
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
}