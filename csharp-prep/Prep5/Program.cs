using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        // // funcrtions in C#
        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hello world");
        // }

        // // accepts single string parameters
        // static void DisplayPersonalMessage(string personalName)
        // {
        //     Console.WriteLine($"{personalName} personal");
        // }

        // //add numbers 
        // static int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // } 

        // main code
        DisplayWelcome();
        string username = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(username, squaredNumber, birthYear);

        // print results
        Console.WriteLine(username);
        Console.WriteLine(favNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your your favoritie number ");
            string userNumber = Console.ReadLine();
            int favNumber = int.Parse(userNumber);
            return favNumber;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write($"Please enter the year you were born: ");
            birthYear = int.Parse(Console.ReadLine());

        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
            Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
        }
    }
}