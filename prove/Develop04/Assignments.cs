using System;

class Assignments
{
    //attributes
    private string[] _menuStrings =
    {
        "Welcome to count",
        "You can create, display, save, and read journal entries",
        "1 - Create Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to file",
        "4 - Read Journal from file",
        "5 - Quit"
    };
    private string _welcomeMSG;
    private string _endMSG;

    //constructors
    public Assignments(string welcomeMSG, string byeMSG)
    {
        _welcomeMSG = welcomeMSG;
        _endMSG = byeMSG;
    }

    //methods
    public string DisplayWelcomeMSG()
    {
        return $"Welcome message: {_welcomeMSG}";
    }
}