using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        //initialize all the required variables
        Console.Write("What is your letter grade? ");
        string userinput = Console.ReadLine();
        int gradePercentage = int.Parse(userinput);

        //Print user input
        Console.WriteLine($"This is your grade percentage {gradePercentage}");

        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            Console.WriteLine("You got an A!");
            letterGrade = "A";
        }
        Console.WriteLine(letterGrade);
    }
}