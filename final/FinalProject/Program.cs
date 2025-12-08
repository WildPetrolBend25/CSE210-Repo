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
        CharacterManager myManager = new CharacterManager();
        Character myChracter = new Character("Null", _status);
        Kanji myKanji = new Kanji ("null", false, "kanji");


        // menthods
        myManager.DisplayMenu();
        myManager.DisplayKanji();


    }
}