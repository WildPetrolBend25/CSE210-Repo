using System;
class Kanji : CharacterManager
{
    // attributes
    string _kanji = "";
    // constructors
    public Kanji(string sentence, bool status, string Kanji) : base(sentence, status)
    {
        _kanji = Kanji;
    }

    // Methods 
    public override string DisplaySentence()
    {
        return base.DisplaySentence();
    }
}