using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.IO;

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
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
        Console.WriteLine();
        Console.Write("Press Enter when you want to continue "); //When you press enter the code continues
        Console.ReadLine();
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals()
    {
        ///nothing here yet (((🦺)))
        /// string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
{
        // You can add text to the file with the WriteLine method
        outputFile.WriteLine("This will be the first line in the file.");

        // You can use the $ and include variables just like with Console.WriteLine
        string color = "Blue";
        outputFile.WriteLine($"My favorite color is {color}");
}
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
        Console.WriteLine($"You have {_totalScore} points!\n");
    }
    public void RecordEvent()
    {
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("You have no goals to record. Create some first!\n");
                Console.ReadLine();
                return;
            }

            ListGoals();  // Shows numbered list

            Console.Write("Which goal did you accomplish? (enter number) ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > _goals.Count)
            {
                Console.WriteLine("Invalid number!");
                Thread.Sleep(1500);
                return;
            }

            int pointsEarned = _goals[choice - 1].RecordEvent();
            _totalScore += pointsEarned;

            Console.WriteLine($"\nCongratulations! You earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_totalScore} total points!\n");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }

}