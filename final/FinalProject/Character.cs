using System;
class Character
{
    //attributes
    private string _sentence = "";
    private bool _status = false;
    //constructors
     public Character(string sentence, bool status)
    {
        _sentence = sentence;
        _status = status;
    }
    //methods
    public virtual string DisplaySentence()
    {
        return $"{_sentence}";
    }
}