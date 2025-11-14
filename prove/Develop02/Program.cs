using System;

class Program
{
    static void Main(string[] args)
    {
        // create new instances
        Menu journalMenu = new Menu();
        Entry userEntry = new Entry();

        //initialize userSelection variable
        int userSelection;

        //code quits when you enter 5
        bool done = false;
        do
        {
            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    //create a new entry object
                    //call create on that object
                    //add the entry to the journal
                    string userResponse = userEntry.CreateEntry();
                    Console.WriteLine("Case 1");
                    Console.WriteLine(userResponse);
                    break;

                case 2:
                //call journal.dispaly()
                    Console.WriteLine("Case 2");
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