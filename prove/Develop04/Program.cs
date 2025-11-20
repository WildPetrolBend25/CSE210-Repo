using System;

class Program
{
    static void Main(string[] args)
    {
        //test code
        Console.WriteLine("Hello Develop04 World!\n");

        //Instances
        Activity myAssignment = new Activity("Base", "This is the base activity");

        //Method calling
        Console.WriteLine(myAssignment.DisplayWelcome());
        Console.WriteLine(myAssignment.DisplayDescription());
    }
}