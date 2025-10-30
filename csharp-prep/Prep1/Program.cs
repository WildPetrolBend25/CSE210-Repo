using System;

class Program
{
    static void Main(string[] args)
    {
        //declare variables
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        //enter your first name
        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        //enter your last name
        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();

        //print full name
        Console.WriteLine($"Your full name is {firstName} {lastName}");
    }
}