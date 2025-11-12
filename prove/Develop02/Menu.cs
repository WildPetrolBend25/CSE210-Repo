using System;
using System.Diagnostics.CodeAnalysis;

class Menu
{
    public string[] _menuStrings =
    {
        "Welcome to count",
        "You can create, display, save, and read journal entries",
        "1 - Create Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to file",
        "4 - Read Journal from file",
        "5 - Quit"
    };

    /* process menu will display the menu to the user and validate the input and return the value.
    There are no parameters*/
    public int ProcessMenu()
    {
        int userSelection = 0;
        bool done = false;
        //run through the code once 
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }

            //get user input
            Console.Write("Which number do you choose? ");

            //make sure user input is valid
            try
            {
                //read user input
                userSelection = int.Parse(Console.ReadLine());
                
                //make sure whole number is between 1 and 5
                if (userSelection > 5 || userSelection < 1)
                {
                    Console.WriteLine("[Error]: Please enter a number between 1 and 5 please");
                }
                else
                {
                    done = true;
                }
            }

            //enters a float or double
            catch (FormatException)
            {
                Console.WriteLine("[Error]: You must enter a whole number (no letters or decimals).");
                Console.WriteLine("");
            }

            //enters a string
            catch (OverflowException)
            {
                Console.WriteLine("[Error]: The number is too large or too small for an int.");
                Console.WriteLine("");
            }
        } while (userSelection < 1 || userSelection > 5 && done != true);

        //return the user's selection
        return userSelection;
    }
}