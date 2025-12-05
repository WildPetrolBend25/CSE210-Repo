using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //attributes 
        string _name;
        string _description;
        int _points;
        bool status = false;
        
        //instances 🟩
        Menu myMenu = new Menu();
        GoalManager myGoals = new GoalManager();
        Simple mySimpleGoal;

        //method calling 🟩

        //go into different activites 🟩
        while (!status)
        {
            int userinput = myMenu.DisplayMenu();  //display the menu
        
            if (userinput == 1) //create goal
            {
                myGoals.DisplayGoals();
                int userGoalsInput = myGoals.ObtainUserInput();
                if (userGoalsInput == 1)
                {
                    //simple goal
                    Console.Clear(); 

                    Console.WriteLine("Welcome to the simple Goal\n");

                    Console.Write("what is the name of the Goal ");
                    _name = Console.ReadLine();

                    Console.Write("what is a short description of it? ");
                    _description = Console.ReadLine();

                    Console.Write("what is the ammount of points associated with this goal? ");
                    string inputPoints = Console.ReadLine();
                    _points = int.Parse(inputPoints);

                    mySimpleGoal = new Simple(_name, _description, _points, status);
                    
                    myGoals.AddGoal(mySimpleGoal); 
                    Console.WriteLine("Goal added successfully!");
                    Console.Clear();
                    
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
                myGoals.ListGoals();
                Console.Clear();
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
                status = true;
                Console.Clear();
                Console.WriteLine("You've exited the program");
            }
        }
    }
}