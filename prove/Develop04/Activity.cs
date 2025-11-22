using System;

class Activity
{
    //attributes ((🟦🟦🟦))
    private string _name;
    private string _description;
    private int _duration;
    DateTime _endTime;

    //constructors ((🟩🟩🟩))
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

   
    //methods ((🟧🟧🟧))
    public string DisplayWelcome() //((✅))
    {
        return $"Weclome to the {_name} activity";
    }

    public string DisplayDescription() //((✅))
    {
        return $"{_description}";
    }

    public void DisplaySpinner(string message, int seconds) //((🦺))
    {
        char[] frames = { '/', '-', '\\', '|' };
        _duration = 5;

        Console.Write("Loading ");

        for (int i = 0; i < 5; i++)
        {
            foreach (char item in frames)
            {
                Console.Write("\b" + item);
                Thread.Sleep(250);
            }
        }
        Console.Write("\b ");  // Final cleanup: erase the spinner

        //set the cursor to pos 0 and erase "Loading" + move cursor to the next line
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, currentLineCursor);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    } 

    public int ObtainDurration() //((✅))
    {
        Console.Write("How many seconds would you like to this activity for? ");
        string input = Console.ReadLine();
        int seconds = int.Parse(input);
        return seconds;
    }


    public void RunCountDown(string message, int seconds) //((🦺))
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\b \b" + i);
            Thread.Sleep(1000);
    
        }
        Console.Write("\b"); 
        Console.WriteLine("Done"); 
    }

    public void AddSeconds() //((🦺))
    { 
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("We have not arrived at our future time yet...");
        }
        else
        {
            Console.WriteLine("We are at a future time now");
        }
    }
}
