using System;

class Program
{
    static void Main(string[] args)
    {
        // create new instances
        Menu journalMenu = new Menu();
        Entry userEntry = new Entry();

        //initialize userSelection
        int userSelection;

        bool done = false;
        //code quits when you enter 5
        do
        {
            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    //create a new entry object
                    //call create on that object
                    //add the entry to the journal
                    Console.WriteLine("Case 1");
                    string userResponse = userEntry.CreateEntry();
                    Console.WriteLine(userResponse);
                    Console.WriteLine("");

                    //user response stored in user response
                    //get the data next (put that info into entry file)
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