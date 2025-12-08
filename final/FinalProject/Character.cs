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
    public virtual string GetSentence()
    {
        return $"{_sentence}";
    }

    public string[] SentenceToArray()
    {
        string[] words = _sentence.Split(" ");
        return words;
        //foreach(string word)
    }

}