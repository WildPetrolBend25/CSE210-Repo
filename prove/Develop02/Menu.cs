using System;

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
        //run through the code once 
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Which number do you choose? ");
            userSelection = int.Parse(Console.ReadLine());
        } while (userSelection < 1 || userSelection > 5);

        //return the user's selection
        return userSelection;
    }
}