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

        //initialize global variables
        int userSelection;
        List<string> fullJournal = new List<string>();

        //while loop to run through our prompt
        bool done = false;
        do
        {
            userSelection = _journalMenu.ProcessMenu();
            switch (userSelection)
            {
                //user enters 1 (creates a journal entry)
                case 1:
                    //make journal entry
                    string userResponse = _userEntry.CreateEntry();

                    //add entry to journal
                    fullJournal = _userJournal.addToJournal(userResponse);
                    Console.WriteLine("");
                    break;

                //user enter 2 (displays the full journal)
                case 2:
                    _userJournal.journalDisplay(fullJournal);
                    Console.WriteLine("");
                    break;

                //user enters 3 (save journal to a file)
                case 3:
                    _userJournal.writeToFile(fullJournal);
                    Console.WriteLine("");
                    break;
                
                //user enters 4 (read journal entry from a file)
                case 4:
                    _userJournal.readFromFile();
                    Console.WriteLine("");
                    
                    break;

                //user enters 5 (quits the code)
                case 5:
                    Console.WriteLine("Come back again soon");
                    done = true;
                    break;
            }
        } while (!done);
       
    }
}