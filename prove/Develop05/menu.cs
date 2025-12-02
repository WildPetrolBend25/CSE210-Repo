using System;

class Menu
{
    //attribues
    private List<string> listMenu = new List<string>
    {
        "Menu Option",
        "1. Create Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit"
    };
    private bool done = false;
    int userInput;
    
    //constructors
    public Menu()
    {
        
    }

    //methods
    public int DisplayMenu()
    {
        //display the menue
        foreach(string item in listMenu)
        {
            Console.WriteLine(item);
        }

        Console.Write("Which activity would you like to do from the menu? ");
        string userResponse = Console.ReadLine();
        userInput = int.Parse(userResponse);

        while (!done)
        {
            try
            {
                if (userInput > 1 || userInput < 6)
                {
                    done = true;
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        return userInput;

    }
    
}