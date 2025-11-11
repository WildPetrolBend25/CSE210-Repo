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

        bool done = false;
        //code quits when you enter 5
        do
        {
            userSelection = _journalMenu.ProcessMenu();
            //List<string> fullJournal;
            //string myname = "this is my name";
            switch (userSelection)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    string userResponse = _userEntry.CreateEntry();
                    Console.WriteLine(userResponse);
                    Console.WriteLine("");
                    List<string> fullJournal = _userJournal.addToJournal(userResponse);
                    break;

                case 2:
                    Console.WriteLine("Case 2");
                    //call journal.dispaly()
                    //_userJournal.journalDisplay(fullJournal); ❌
                    //Console.WriteLine(myname);
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
                    Console.WriteLine("Case 5");
                    done = true;
                    break;
            }
        } while (!done);
    }
}

//entring a float number or string will crash the system