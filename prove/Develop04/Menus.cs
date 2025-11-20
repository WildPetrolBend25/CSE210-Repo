using System;

class Menu
{
    //attributes
    protected string[] _menu = {
        "Activity Menu",
        "1. Breathing Activity",
        "2. Reflection Activity",
        "3. Listing Activity"
    };

    //constrcutors
    public Menu()
    {
        //nothing here to see
    }

    //methods
    public void DisplayMenu()
    {
        foreach (string item in _menu)
        {
            Console.WriteLine(item);
        }
    }
}