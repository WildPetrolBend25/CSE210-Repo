using System;
using System.Reflection;
class CharacterManager
{
    //attributes
   

    // instances
    Menu mymenu = new Menu();
    Kanji myKanji = new Kanji("Sentence", false, "kanji"); //(((🧰))) stack overflow error

    // constructors
    public CharacterManager()
    {
        
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

    public void DisplayKanji() //(((🧰))) fix
    {
        myKanji.DisplaySentence();
    }

}