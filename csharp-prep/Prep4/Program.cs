using System.Collections.Generic;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        // // List<string> words;
        // // make a list, declare its data type and then set aside place in memory for list
        // List<int> numbers;
        // numbers = new List<int>();

        // List<string> words = new List<string>();
        // words.Add("Hello");
        // words.Add("you");
        // words.Add("are");
        // words.Add("gay");

        // // print each item in the list
        // foreach (string i in words)
        // {
        //     Console.WriteLine(i);
        // }
        // // getting the list size
        // Console.WriteLine(words.Count);

        // // geting an item at an index
        // for (int i = 0; i <words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }


        // start message
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // set up the list
        List<int> listOfNumbers = new List<int>();

        // while loop for the list
        int finalNumber = 1;
        do
        {
            if (finalNumber != 0)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                int number = int.Parse(userInput);
                listOfNumbers.Add(number);
                finalNumber = number;
            }


        } while (finalNumber != 0);
        Console.WriteLine("You got out of the while loop");

        // run through the items in the list
        int sumTotal = 0;
        int average = 0;
        int bigNumber = 0;

        foreach (int number in listOfNumbers)
        {
            // Console.WriteLine(number);
            sumTotal = sumTotal + number;
        }
        Console.WriteLine(sumTotal);

    }
}