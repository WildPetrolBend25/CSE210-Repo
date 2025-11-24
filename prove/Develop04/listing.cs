using System;

class Listing : Activity
{

    // attributes
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public Listing(string name, string description) :base (name, description)
    {
        
    }

    public void RunActivityLogicL()
    {
        //nothing here yet 
    }
}