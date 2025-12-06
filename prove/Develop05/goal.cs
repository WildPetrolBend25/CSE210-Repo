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
    public Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoint = points;
        _status = status;
        _goalType = "Goal";

    }

    //methods
    protected bool IsCompleted // replaces _status
        {
            get { return _status; }
            set { _status = value; }
        }
    protected int Points // replaces _numberOfPoint
        {
            get { return _numberOfPoint; }
            set { _numberOfPoint = value; }
        }
        protected string GoalType // new property for goal type
        {
            get { return _goalType; }
            set { _goalType = value; }
        }
   
    public virtual string GetStringRepresentation()
    {
        if (_status == false)
        {
            return $"[ ] {_name}, {_description}";
        }
        else
        {
            return $"[X] {_name}, {_description}";
        }
    }
    public virtual string GetStringRepresentationForSaving()
        {
            // The format should be: Type:Name,Description,Points,Status
            // Status is '1' for complete, '0' for not.
            return $"{GoalType}: {_name},{_description},{_numberOfPoint},{(_status ? "1" : "0")}";
        }
    public virtual int RecordEvent()
    {
        return 0;  // base does nothing — will be overridden
    }
}