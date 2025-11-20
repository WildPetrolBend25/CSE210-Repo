using System;

class Activity
{
    //attributes
    private string _name;
    private string _description;
    private int _duration;
    DateTime _endTime;

    //constructors
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    //methods
    public string DisplayWelcome()
    {
        return $"Weclome to the {_name} activity";
    }

    public string DisplayDescription()
    {
        return $"{_description}";
    }
}