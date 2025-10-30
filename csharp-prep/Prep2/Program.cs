using System;

class Program
{
    static void Main(string[] args)
    {

        //initialize all the required variables
        Console.Write("What is your grade percentage? ");
        string userinput = Console.ReadLine();
        int gradePercentage = int.Parse(userinput);

        //Figure out the grade based on the 
        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        //Check to see if he/she passed the class
        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C" || letterGrade == "D")
        {
            Console.WriteLine($"Your letter grade is {letterGrade}");
            Console.WriteLine("Congrats, you passed the course");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letterGrade}");
            Console.WriteLine("Better luck next time");
        }
    }
}