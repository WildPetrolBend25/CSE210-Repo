using System;
class Character
{
    //attributes
    private string _sentence = "";
    private bool _isHidden;
    
    //constructors
     public Character(string sentence) /*Step 9: Items passed in from ChracterManager's "myCharacter" 
    instance are passed in -> ChracterManager class */
    {
        _sentence = sentence;
        _isHidden = false;
    }
    //methods
    public virtual string GetSentence()
    {
        return $"{_sentence}";
    }

    public string[] SentenceToArray() /*Step 12: returns the sentence that was passed in in step 9 
    into an Array -> ChracterManager:DisplaySentence method */
    {
        return _sentence.Select(c => c.ToString()).ToArray(); //turns all the elements of the string into chracters
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public void HideCharacter()
    {
        _isHidden = true;
    }
}