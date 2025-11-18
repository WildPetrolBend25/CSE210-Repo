using System;

class Program
{
    static void Main(string[] args)
    {
        //test code
        Console.WriteLine("Hello Learning04 World!");

        //instances
        Assignments myAssignment = new Assignments("Billy", "Math");
        
        //call methods
        Console.WriteLine(myAssignment.GetSummary());
    }
}