using System;
class Character
{
    //attributes
    private string _sentence = "";
    private bool _status = false;
    
    //constructors
     public Character(string sentence, bool status) /*Step 9: Items passed in from ChracterManager's "myCharacter" 
    instance are passed in -> ChracterManager class */
    {
        _sentence = sentence;
        _status = status;
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

}