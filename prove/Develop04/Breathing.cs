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
        int _duration = ObtainDurration();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            RunCountDown(4);
            Console.WriteLine();
            
            Console.Write("Now breathe out... ");
            RunCountDown(6);
            Console.WriteLine("\n");
        }
    }

}