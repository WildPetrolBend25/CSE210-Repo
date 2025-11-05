using System;
using System.Drawing;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // //while loops
        // string response = "yes";
        // while (response == "yes")
        // {
        //     Console.Write("do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // //do while loops
        // do
        // {
        //     Console.Write("Do you want to contine? ");
        //     response = Console.ReadLine();
        // } while (response == "yes");

        // //for loops
        // for (int i = 0; i < 11; i++) //i++ (increment by one), i=i + 2(increment by two)
        // {
        //     Console.WriteLine(i);
        // }

        // //random number genrator between two parameters
        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);

        //Start main code

        //initialize magic number
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);

        //Get the user guess
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);



        int loopGuess = userGuess;
        while (loopGuess != magicNumber)
        {
            //lower && higher
            if (magicNumber == loopGuess)
            {
                Console.WriteLine("Congrats, You guessed the number");
            }
            else if (magicNumber > loopGuess)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your new guess ");
                string newGuess = Console.ReadLine();
                int finalGuess = int.Parse(newGuess);
                loopGuess = finalGuess;
            }
            else if (magicNumber < loopGuess)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your new guess ");
                string newGuess = Console.ReadLine();
                int finalGuess = int.Parse(newGuess);
                loopGuess = finalGuess;
            }

        }
        

    }
}