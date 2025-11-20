using System;

class Program
{
    static void Main(string[] args)
    {
        //test code
        Console.WriteLine("Hello Develop04 World!\n");

        //Instances
        Activity myAssignment = new Activity("Base", "This is the base activity");
        Menu myMenu = new Menu();

        //Method calling
        myMenu.DisplayMenu(); //get the menu displayed
        int userinput = myMenu.GetUserInput(); //get the user's input

        //move into other activities
        bool done = false;
        while (!done)
        {
            if (userinput == 1)
            {
                Console.WriteLine(myAssignment.DisplayWelcome());
                Console.WriteLine(myAssignment.DisplayDescription());
                done = true;
            }
            
        }
    }
}