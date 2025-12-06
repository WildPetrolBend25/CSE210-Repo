using System;
class Eternal : Goal
{
    //attribues

    //constrcutors
    public Eternal(string name, string description, int points, bool status) : base(name, description, points, status)
    {
        GoalType = "Eternal";
    }
    //methods
    public override int RecordEvent()
    {
        return Points;  
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
    public override string GetStringRepresentationForSaving()
    {
        return base.GetStringRepresentationForSaving();
    }
}