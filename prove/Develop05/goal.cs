using System;

class Goal
{
    //attributes
    private string _name;
    private string _description;
    private int _numberOfPoint;
    private bool _status;
    private string _goalType;

    //constructors
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _numberOfPoint = 0;
        _status = false;
        _goalType = "";
    }

    //methods
    public virtual string GetConsoleString()
    {
        return $"Name: {_name}, Description: {_description}, Points: {_numberOfPoint}";
    }
}