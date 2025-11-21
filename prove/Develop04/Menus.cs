using System;
using System.Runtime.CompilerServices;

class Menu
{
    //attributes ((🟦🟦🟦))
    protected string[] _menu = {
        "Activity Menu",
        "1. Base Activity",
        "2. Breathing Activity",
        "3. Reflection Activity",
        "4. Listing Activity",
        "5. Quit"
    };
    

    //constrcutors ((🟩🟩🟩))
    public Menu()
    {
        //nothing here to see
    }

    //methods ((🟧🟧🟧))
    public void DisplayMenu()
    {
        foreach (string item in _menu)
        {
            Console.WriteLine(item);
        }
    }

    public int GetUserInput()
    {
        bool done = false;
        int number = 0;

        do
        {
            Console.Write("What is your input? ");
            string input = Console.ReadLine();
            try
            {
                number = int.Parse(input);

                if (number < 1 || number > 5)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else
                {
                    done = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Enter an integer between 1 and 3 please.");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again.");
            }
    
            Console.WriteLine(); // blank line for neatness
            
        } while (!done);
        
        return number;
    }
    
}