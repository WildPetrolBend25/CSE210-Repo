using System;

class Program
{
    // static void = can call the function without a return value.
    //must always return a value except when calling void
    static void Main(string[] args)
    {
        //write line moves the cursor to the next line
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        //console. write leaves the cursor after the after the print statement so that you can input something
        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your full name is {firstName} {lastName}");

        int x = 10;

        if (!(x == 10 || x == 12 && x == 13 && x != 23))
        {
            Console.WriteLine($"X is {x}");
        }
        
    }
}