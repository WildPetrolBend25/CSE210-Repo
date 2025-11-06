using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        journalMenu.ProcessMenu();
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
                    break;
                case 2:
                //call journal.dispaly()
                    break;
                case 3:
                //save to a file
                    break;
                case 4:
                //read from a file
                    break;
                case 5:
                //quit the code
                    done = true;
                    break;
            }
        } while (!done);
    }
}

//entring a float number or string will crash the system