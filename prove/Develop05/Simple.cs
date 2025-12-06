using System;

class Simple : Goal
{
    //attributes
  

    //constructors
    public Simple(string name, string description, int points, bool status) : base(name, description, points, status)
    {
        GoalType = "Simple";
    }

    //methods 

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
    public override string GetStringRepresentationForSaving()
    {
        return base.GetStringRepresentationForSaving();
    }

    public override int RecordEvent()
    {
        if (!IsCompleted)           
        {
            IsCompleted = true;
            return Points + 500;  //bonus points. YAY :D
        }
        return 0;               
    }


}