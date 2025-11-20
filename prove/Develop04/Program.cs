using System;

class Program
{
    static void Main(string[] args)
    {
        //test code
        Console.WriteLine("Hello Develop04 World!\n");

        //Instances
        Assignments myAssignment = new Assignments("Welcome to assignments program", "See you again soon");

        //Method calling
        Console.WriteLine(myAssignment.DisplayWelcomeMSG());
    }
}