using System;
using System.Reflection;
class CharacterManager
{
    //attributes
   

    // instances
    Menu mymenu = new Menu();
    private Character myCharacter;
    //Kanji myKanji = new Kanji("Sentence", false, "kanji"); (((Take a little break 🦺)))

    // constructors
    public CharacterManager()
    {
        myCharacter = new Character("How was your day?", false);
    }

    // methods
    public void DisplayMenu()
    {
        List<string> _menuOptions = mymenu.GetMenu();
        foreach (string item in _menuOptions)
        {
            Console.WriteLine(item);
        }
    }

    public void DisplaySentence()
    {
        string[] ArraySentence = myCharacter.SentenceToArray();
        foreach (string item in ArraySentence)
        {
            Console.WriteLine(item);
        }
        // Console.WriteLine(myCharacter.GetSentence());
    }

    // public void DisplayKanji() (((Take a little break 🦺)))
    // {
    //     Console.WriteLine(myKanji.DisplaySentence());
    // }

}