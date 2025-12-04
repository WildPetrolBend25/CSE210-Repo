using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //instances 🟩
        Menu myMenu = new Menu();
        Goal myGoal = new Goal("Run", "Run a lot faster", 0);
        Goals myGoals = new Goals();
       

        //method calling 🟩
        int userinput = myMenu.DisplayMenu();  //display the menu

        //go into different activites 🟩
        if (userinput == 1) //create goal
        {
            myGoals.DisplayGoals();
            int userGoalsInput = myGoals.ObtainUserInput();
            if (userGoalsInput == 1)
            {
                //simple goal
                Console.WriteLine("This will be the simple goal will go\n");

                Console.Write("what is the name of the Goal ");
                string _name = Console.ReadLine();

                Console.Write("what is a short description of it? ");
                string _description = Console.ReadLine();

                Console.Write("what is the ammount of points associated with this goal? ");
                string inputPoints = Console.ReadLine();
                int _points = int.Parse(inputPoints);

                Simple mySimpleGoal = new Simple(_name, _description, _points);
                Console.WriteLine(mySimpleGoal.GetConsoleString());


            }
            else if(userGoalsInput == 2)
            {
                //eternal goals
                Console.Clear();
                Console.WriteLine("This is where the eternal goals wiil go");
            }
            else
            {
                //checklist goals
                Console.Clear();
                Console.WriteLine("This is where the checklist goal will go");
            }

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