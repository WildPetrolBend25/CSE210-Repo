using System;
class Character
{
    //attributes
    private string _sentence;
    private bool _isHidden;
    
    //constructors
     public Character(string sentence) /*Step []: Items passed in from ChracterManager's "myCharacter" 
    instance are passed in -> ChracterManager class */
    {
        _sentence = sentence;
        _isHidden = false;
    }

    //methods
    public string GetDisplayWord() 
    //step []: returns either underscores or the actual word based on hidden state,
    //since text classes constructor set all words to hidden, this will initially return underscores
    // -> Program class GetDisplayText method
    {
        if (_isHidden) //if true -> return underscores
        {
            string newString = "";
            foreach(char c in _sentence)
                newString += '_';
            return newString;
        }
        else
        {
            return _sentence; //if false -> return actual word
        }
    }

    public string[] SentenceToArray() /*Step []: returns the sentence that was passed in in step 9 
    into an Array -> ChracterManager:DisplaySentence method */
    {
        return _sentence.Select(c => c.ToString()).ToArray(); //turns all the elements of the string into chracters
    }

    public void SetHidden(bool hidden) //step []: Our setter, sets the hidden state of the word. test -> revealnewword method
    {
        _isHidden = hidden;
    }

    //__________________________________________ Added Code ____________________________________________
    // private string _word; 
    // private bool _isHidden;

    // public Word(string word)
    // {
    //     _word = word;
    //     _isHidden = false; // default value – we change it later anyway
    // }

    // public void SetHidden(bool hidden) //step 13: Our setter, sets the hidden state of the word. test -> revealnewword method
    // {
    //     _isHidden = hidden;
    // }

    // public string GetDisplayWord() 
    // //step 9: returns either underscores or the actual word based on hidden state,
    // //since text classes constructor set all words to hidden, this will initially return underscores
    // // -> Program class GetDisplayText method
    // {
    //     if (_isHidden) //if true -> return underscores
    //     {
    //         string newString = "";
    //         foreach(char c in _word)
    //             newString += '_';
    //         return newString;
    //     }
    //     else
    //     {
    //         return _word; //if false -> return actual word
    //     }
    // }
}