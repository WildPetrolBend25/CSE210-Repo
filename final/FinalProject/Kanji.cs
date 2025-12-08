using System;
class Kanji : Character
{
    // attributes
    private string _kanji = "";
    // constructors
    public Kanji(string sentence, bool status, string kanji) : base(sentence, status)
    {
        _kanji = kanji;
    }

    // Methods 
    public override string DisplaySentence()
    {
        return $"My Kanji is: {base.DisplaySentence()} + {_kanji}";
    }
}