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

                    Console.WriteLine("Welcome to the Simple Goal\n");

                    Console.Write("what is the name of the Goal ");
                    _name = Console.ReadLine();

                    Console.Write("what is a short description of it? ");
                    _description = Console.ReadLine();

                    Console.Write("what is the ammount of points associated with this goal? ");
                    string inputPoints = Console.ReadLine();
                    _points = int.Parse(inputPoints);

                    mySimpleGoal = new Simple(_name, _description, _points, status);
                    
                    myGoals.AddGoal(mySimpleGoal); 
                    Console.WriteLine("Simple Goal added successfully!");
                    Console.Write("Press Enter to continue... ");
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                else if(userGoalsInput == 2)
                {
                    //eternal goals
                    // Eternal Goal
                    Console.Clear();
                    Console.WriteLine("Welcome to the Eternal Goals \n");

                    Console.Write("What is the name of your eternal goal? ");
                    _name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();

                    Console.Write("How many points is this goal worth each time you do it? ");
                    _points = int.Parse(Console.ReadLine());

                    Eternal eternalGoal = new Eternal(_name, _description, _points, status); // keep an eye on status
                    myGoals.AddGoal(eternalGoal);

                    Console.WriteLine("Eternal Goal created successfully!");
                    Console.Write("Press Enter to continue... ");
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                else
                {
                    //checklist goals
                    Console.Clear();
                    Console.WriteLine("Welcome to the Checklist Goals\n");

                    Console.Write("What is the name of your checklist goal? ");
                    _name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();

                    Console.Write("How many points is this goal worth each time? ");
                    _points = int.Parse(Console.ReadLine());

                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    Checklist checklistGoal = new Checklist(_name, _description, _points, status, target, bonus);
                    myGoals.AddGoal(checklistGoal);

                    Console.WriteLine("Checklist Goal created successfully!");
                    Console.Write("Press Enter to continue... ");
                    Console.ReadLine();
                    Console.Clear();
                    
                }

            }
            else if (userinput == 2) //list goals
            {
                myGoals.ListGoals();
                myGoals.DisplayScore();
                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
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
                myGoals.RecordEvent();
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