using System;

class Simple : Goal
{
    //attributes


    //constructors
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        
    }

    //methods 
    public override string GetConsoleString()
    {
        return base.GetConsoleString();
    }

}