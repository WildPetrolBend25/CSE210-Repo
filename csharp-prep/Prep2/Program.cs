using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //initialize all the required variables
        Console.Write("What is your letter grade? ");
        string userinput = Console.ReadLine();
        int gradePercentage = int.Parse(userinput);
        Console.WriteLine($"This is your grade percentage {gradePercentage}");
    }
}