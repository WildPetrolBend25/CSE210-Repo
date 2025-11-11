using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // create new instances
        Menu _journalMenu = new Menu();
        Entry _userEntry = new Entry();
        Journal _userJournal = new Journal();

        //initialize userSelection
        int userSelection;
        List<string> fullJournal = new List<string>();
        bool done = false;
        //code quits when you enter 5
        do
        {
            userSelection = _journalMenu.ProcessMenu();
            switch (userSelection)
            {
                case 1:
                    //make journal entry
                    string userResponse = _userEntry.CreateEntry();
                    Console.WriteLine(userResponse);

                    //add entry to journal
                    fullJournal = _userJournal.addToJournal(userResponse);
                    Console.WriteLine("");
                    break;

                case 2:
                    //display the full journal
                    _userJournal.journalDisplay(fullJournal);
                    Console.WriteLine("");
                    
                    break;

                case 3:
                //save to a file
                    Console.WriteLine("Case 3");
                    break;

                case 4:
                //read from a file
                    Console.WriteLine("Case 4");
                    break;

                case 5:
                //quit the code
                    Console.WriteLine("This quits the code");
                    done = true;
                    break;
            }
        } while (!done);
       
    }
}

//entring a float number or string will crash the system