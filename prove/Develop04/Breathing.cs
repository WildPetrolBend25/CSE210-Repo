using System;
using System.Data;
using System.Runtime.InteropServices;

class Breathing : Activity
{
    //constructors
    public Breathing(string name, string description) :base (name, description)
    {
        
    }

    //methods
    public void RunBActivity()
    {
        Console.WriteLine("");
        
        int _durration = ObtainDurration();
        Console.Write("Breath in:  ");
        RunCountDown( _durration);

        Console.Write("Breathe out:  ");
        RunCountDown(_durration);

        Console.WriteLine("Done");
    }

}