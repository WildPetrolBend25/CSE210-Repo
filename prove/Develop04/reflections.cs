using System;
using System.Collections.Generic;

class Reflection: Activity
{
    // attributes
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "How can you keep this feeling going forward?"
    };

    //constructor
    public Reflection(string name, string description) : base(name, description)
    {
        
    }

    //methods 
    public void RunActivityLogicR()
    {
        // nothing here folks
    }
}