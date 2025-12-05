using System;
class Eternal : Goal
{
    //attribues

    //constrcutors
    public Eternal(string name, string description, int points, bool status) : base(name, description, points, status)
    {
        
    }
    //methods
    public override int RecordEvent()
    {
        return Points;  
    }
    public override string GetStringRepresentation()
    {
        return $"[ ] {name} ({description})";  // Always [ ] — never done!
    }
}