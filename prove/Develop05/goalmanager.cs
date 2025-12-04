using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class GoalManager
{
    //attributes
    private List<string> goalTypes = new List<string>
    {
        "The Type of Goals are:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. Checklist Goal",
    };
    private string _filename;
    private int _totalScore;
    private bool done = false;
    private int userInput;
    private List <Goal> _goals = new List<Goal>();

    //constructors
        
    //methods
    public void ListGoals()  
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.\n");
            return;
        }

        Console.WriteLine("Your goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
        Console.WriteLine();
    }
    public void AddGoal(Goal goal)
    {
        //nothing here yet (((🦺)))
        _goals.Add(goal);
    }
    public void LoadGoals()
    {
        ///nothing here yet (((🦺)))
    }
    public void SaveGoals()
    {
        //nothing here yet (((🦺)))
    }
    public void DisplayGoals()
    {
        foreach (string item in goalTypes)
        {
            Console.WriteLine(item);
        }
    }

    public int ObtainUserInput()
    {
       while (!done)
        {
            Console.Write("Which type of Goal would you like to create ");
            try
            {
            string userResponse = Console.ReadLine();
            userInput = int.Parse(userResponse);

                if (userInput >= 1 && userInput <= 3)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                    Thread.Sleep(2000); 
                    Console.Clear();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                Thread.Sleep(2000);
            }
        } 
        int choice = userInput;  
        done = false;            
        userInput = 0;          
        return choice;
    }

    public void DisplayScore()
    {
        Console.WriteLine(_totalScore); //(((🦺)))
    }
    public void RecordEvent()
    {
        //nothing here yet (((🦺)))
    }

}