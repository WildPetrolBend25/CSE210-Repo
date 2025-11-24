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
    public void RunActivityLogicB()
    {
        int _duration = ObtainDurration();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            RunCountDown(4);
            
            Console.Write("Now breathe out... ");
            RunCountDown(6);
        }
    }

}