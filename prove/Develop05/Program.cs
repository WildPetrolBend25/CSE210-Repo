using System;

class Program
{
    static void Main(string[] args)
    {
        //instances 🟩
        Menu myMenu = new Menu();
        Goal myGoal = new Goal("Run", "Run a lot faster");
        Goals myGoals = new Goals();

        //method calling 🟩
        int userinput = myMenu.DisplayMenu();  //display the menu

        //go into different activites 🟩
        if (userinput == 1) //create goal
        {
            myGoals.DisplayGoals();
            Console.WriteLine("\n");
            Console.WriteLine(myGoal.GetConsoleString());
        }
        else if (userinput == 2) //list goals
        {
            
        }
        else if (userinput == 3) //save goals
        {
            
        }
        else if (userinput == 4) //load goals
        {
            
        }
        else if (userinput == 5) //record event
        {
            
        }
        else //exit the program
        {
            Console.WriteLine("You've exited the program");
        }
    }
}