using System;
using System.ComponentModel;

class Goals
{
    //attributes
    private List<string> ListofGoals = new List<string>
    {
        "The Type of Goals are:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. Checklist Goal",
        "Which type of Goal would you like to create"
    };
    private string _filename;
    private int _totalScore;
    private bool done = false;

    //constructors

    //methods
    public void DisplayGoals()
    {
        foreach (string item in ListofGoals)
        {
            Console.WriteLine(item);
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine(_totalScore);
    }
}