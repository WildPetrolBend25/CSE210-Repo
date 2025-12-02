using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        //instances 🟩
        Menu myMenu = new Menu();
        Goal myGoal = new Goal("Run", "Run a lot faster");

        //method calling 🟩
        //display the menu
        int userinput = myMenu.DisplayMenu();

        //go into different activites 
        if (userinput == 1)
        {
            Console.WriteLine("\n");
            Console.WriteLine(myGoal.GetConsoleString());
        }
    }
}