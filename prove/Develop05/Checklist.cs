using System;
using System.Runtime.CompilerServices;

class Checklist : Goal
{
    //attributes
    private int _target;
    private int _current;
    private int _bonus;
    //constructors
    public Checklist(string name, string description, int points, bool status, int target, int bonus) : base (name, description, points, status)
    {
        _target = target;
        _current = 0;
        _bonus = bonus;
    }

    //methods
    public override int RecordEvent()
        {
            _current++;
            if (_current >= _target && !IsCompleted)
            {
                IsCompleted = true;
                return Points + _bonus;  // Big bonus when finished! YAY :D
            }
            return Points;
        }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}