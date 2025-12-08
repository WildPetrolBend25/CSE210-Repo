using System;

class Program
{
    static void Main(string[] args)
    {
        // test code
        Console.WriteLine("Hello FinalProject World!");

        // attributes 
        bool _status = false;

        // instances
        CharacterManager myManager = new CharacterManager("Null", _status);

        // menthods
        myManager.DisplayMenu();
        // myManager.DisplayKanji();


    }
}