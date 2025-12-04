using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Goals
{
    //attributes
    private List<string> ListofGoals = new List<string>
    {
        "The Type of Goals are:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. Checklist Goal",
    };
    private string _filename;
    private int _totalScore;
    private bool done = false;
    private int userInput;

    //constructors

    //methods
    public void DisplayGoals()
    {
        foreach (string item in ListofGoals)
        {
            Console.WriteLine(item);
        }
    }

    public int ObtainUserInput()
    {
       bool done = false;
       while (!done)
        {
            Console.Write("Which type of Goal would you like to create ");
            try
            {
            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);

                if (userInput >= 1 && userInput <= 3)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    Thread.Sleep(2000); 
                    Console.Clear();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                Thread.Sleep(2000);
            }
        } 
        return userInput;
    }

    public void DisplayScore()
    {
        Console.WriteLine(_totalScore);
    }
}