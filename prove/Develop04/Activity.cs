using System;

class Activity
{
    //attributes ((🟦🟦🟦))
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    //constructors ((🟩🟩🟩))
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
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

    public int ObtainDurration() //((✅))
    {
        Console.Write("How many seconds would you like to this activity for? ");
        string input = Console.ReadLine();
        int seconds = int.Parse(input);
        return seconds;
    }

    public void DisplaySpinner(int seconds = 3) 
    {
        char[] frames = { '/', '-', '\\', '|' };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (char item in frames)
                {
                    Console.Write("\b" + item);
                    Thread.Sleep(250);
                }
            }
        }
        Console.Write("\b ");  // Final cleanup: erase the spinner

        //set the cursor to pos 0 and erase "Loading" + move cursor to the next line
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, currentLineCursor);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    } 


    public void RunCountDown(int startFrom = 5) //((✅))
    {
        for (int i = startFrom; i > 0; i--)
        {
            Console.Write("\b \b" + i);
            Thread.Sleep(1000);
        }
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, currentLineCursor);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }

    public void StartActivity()
    {
        // nothing here yet
        Console.Clear();
        Console.WriteLine(DisplayWelcome());
        Console.WriteLine(DisplayDescription() + "\n");

        _duration = ObtainDurration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);

        Console.WriteLine("\nWell done!!\n");
        DisplaySpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        DisplaySpinner(4);
    }
}
