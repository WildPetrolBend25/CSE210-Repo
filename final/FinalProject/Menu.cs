using System;
using System.Reflection.Metadata;
class Menu
{
    // attributes
    private bool done = false;
    List<string> _menuOptions = new List<string>()
    {
        "Menu Options:",
        "(1) Study New Sentence",
        "(2) Quit"
    };

    // constructors
    public Menu()
    {
        
    }
    // methods:
    public int ObtainUserInput()
    {
        int userInput = 0;

        while (!done)
        {
            Console.Write("Please enter an integer for the corresponding Menu Option ");
            try
            {
            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);

                if (userInput >= 1 && userInput <= 2)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("<Error> Please enter a valid number");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("<Error: Invalid input>. Please enter a number between 1 and 2.");
                Thread.Sleep(2000);
            }
        } 
        Console.WriteLine();
        return userInput;
        
    }

    public void DisplayMenu() 
    {
        foreach (string item in _menuOptions)
        {
            Console.WriteLine(item);
        }
    }

}