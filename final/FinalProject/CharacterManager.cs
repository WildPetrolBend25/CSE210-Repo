using System;
using System.Reflection;
class CharacterManager
{
    //attributes
    private string _sentence = "";
    private bool _status = false;

    // instances
    Menu mymenu = new Menu();
    //Kanji myKanji = new Kanji("Sentence", false, "kanji"); (((🧰))) stack overflow error

    // constructors
    public CharacterManager(string sentence, bool status)
    {
        _sentence = sentence;
        _status = status;
    }

    // methods
    public virtual string DisplaySentence()
    {
        return $"{_sentence}";
    }
    public void DisplayMenu()
    {
        List<string> _menuOptions = mymenu.GetMenu();
        foreach (string item in _menuOptions)
        {
            Console.WriteLine(item);
        }
    }

    // public void DisplayKanji() (((🧰))) fix
    // {
    //     myKanji.DisplaySentence();
    // }

}