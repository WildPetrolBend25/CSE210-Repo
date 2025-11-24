using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Instances ((🟦🟦🟦))
        Activity myActivity = new Activity("Base", "This is the base activity");
        Menu myMenu = new Menu();
        Breathing breathingActivity = new Breathing("Breathing Activity", "Here, you'll practice your breathing");

        //Method calling ((🟩🟩🟩))
        myMenu.DisplayMenu(); //get the menu displayed
        int userinput = myMenu.GetUserInput(); //get the user's input

        //move into other activites ((🟧🟧🟧))
        Console.Clear();
        Thread.Sleep(1000);
        if (userinput == 1)
            {
                breathingActivity.StartActivityPart1();
                breathingActivity.RunActivityLogicB();
                breathingActivity.StartActivityPart2();
            }
            else if (userinput == 2)
            {
                Console.WriteLine("This is where reflections will go");

            }
            else if(userinput == 3)
            {
                Console.WriteLine("this is where the list activity will go");
                
            }
            else
            {
                Console.WriteLine("You've quit the program");
            }

    }
}