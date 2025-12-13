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
        "(2) Save Sentence",
        "(3) Load Sentence",
        "(4) Quit"
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

                if (userInput >= 1 && userInput <= 4)
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