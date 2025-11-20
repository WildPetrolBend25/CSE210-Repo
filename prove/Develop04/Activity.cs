using System;

class Activity
{
    //attributes
    private string _name;
    private string _description;
    private int _duration;
    DateTime _endTime;

    //constructors
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    //methods
    public string DisplayWelcome()
    {
        return $"Weclome to the {_name} activity";
    }

    public string DisplayDescription()
    {
        return $"{_description}";
    }

    public void PauseProgram()
    {
        Console.WriteLine("Going to sleep for a second...");
        Thread.Sleep(1000);
        DisplaySpinner();
        Console.WriteLine("I'm back!!");
        Console.WriteLine("");
    }

    public void DisplaySpinner()
    {
        int duration = 5;  // about 15 seconds total
        char[] frames = { '/', '-', '\\', '|' };

        Console.Write("Loading ");  // Starting text

        for (int i = 0; i < duration * 4; i++)
        {
            Console.Write("\b" + frames[i % 4]);  // Overwrite the previous character
            Console.Out.Flush();                  // ← THIS IS THE KEY!
            Thread.Sleep(250);                    // 4 frames per second
        }

        Console.Write("\b ");  // Final cleanup: erase the spinner
        Console.Out.Flush();
    } 
}
