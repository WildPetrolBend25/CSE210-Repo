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

        int userinput = 0; //ask for user input
        Console.Write("What is your input? ");
        string ReadLine = Console.ReadLine();
        userinput = int.Parse(ReadLine);
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