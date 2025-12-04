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
    
        while (!done)
        {
            //display the menu
            foreach(string item in listMenu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Which activity would you like to do from the menu? ");

            try
            {
            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);

                if (userInput >= 1 && userInput <= 6)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    Thread.Sleep(2000); 
                    Console.Clear();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                Thread.Sleep(2000);
            }
        }
        int choice = userInput;  
        done = false;           
        userInput = 0;         
        return choice;
    }
    
}