using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Instances ((🟦🟦🟦))
        Menu myMenu = new Menu();
        Breathing breathingActivity = new Breathing("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflection reflectionActivity = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listingActivity = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

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

                reflectionActivity.StartActivityPart1();
                reflectionActivity.RunActivityLogicR();
                reflectionActivity.StartActivityPart2();

            }
            else if(userinput == 3)
            {
                Console.WriteLine("this is where the list activity will go");
                listingActivity.StartActivityPart1();
                listingActivity.RunActivityLogicL();
                listingActivity.StartActivityPart2();
                
            }
            else
            {
                Console.WriteLine("You've quit the program");
            }

    }
}