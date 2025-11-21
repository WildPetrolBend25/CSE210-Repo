using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //test code
        Console.WriteLine("Hello Develop04 World!\n");

        //Instances ((🟦🟦🟦))
        Activity myActivity = new Activity("Base", "This is the base activity");
        Menu myMenu = new Menu();
        Breathing breathingActivity = new Breathing("Breathing Activity", "Here, you'll practice your breathing");

        //Method calling ((🟩🟩🟩))
        myMenu.DisplayMenu(); //get the menu displayed
        int userinput = myMenu.GetUserInput(); //get the user's input

        //make it look like code is loading
        //myActivity.DisplaySpinner(); //((✅))
        //test AddSeconds. What does it do?
        //myActivity.AddSeconds(); //((✅))
        //countdown annimation
        //myActivity.RunCountDown(); //(((✅)))


        //move into other activites ((🟧🟧🟧))
        if (userinput == 1)
            {
                Console.WriteLine(myActivity.DisplayWelcome());
                Console.WriteLine(myActivity.DisplayDescription());

            }
            else if (userinput == 2)
            {
                Console.WriteLine("We'll put the breathing activity here"); //(((❌)))

                Console.WriteLine(breathingActivity.DisplayWelcome());
                Console.WriteLine(breathingActivity.DisplayDescription());
                int durration = breathingActivity.ObtainDurration();
                breathingActivity.RunCountDown("hello", durration);
            }
            else if(userinput == 3)
            {
                Console.WriteLine("This is where reflections will go");
            }
            else if (userinput == 4)
            {
                Console.WriteLine("this is where the list activity will go");
            }
            else
            {
                Console.WriteLine("You've quit the program");
            }

    }
}