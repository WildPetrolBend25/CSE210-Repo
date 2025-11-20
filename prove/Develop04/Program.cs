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

        //moveing into other activities
        if (userinput == 1)
        {
            Console.WriteLine(myAssignment.DisplayWelcome());
            Console.WriteLine(myAssignment.DisplayDescription());
            
        }
        else if (userinput == 2)
        {
            Console.WriteLine("We'll put the breathing activity here");
        }
        else if(userinput == 3)
        {
            Console.WriteLine("This is where reflections will go");
        }
        else
        {
            Console.WriteLine("this is where the list activity will go");
        }
    
    }
}