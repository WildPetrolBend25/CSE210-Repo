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

    public void ProcessMenu()
    {
        foreach(string menuItem in _menuStrings)
        {
            Console.WriteLine(menuItem);
        }
    }
}