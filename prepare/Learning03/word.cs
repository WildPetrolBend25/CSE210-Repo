using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

class Word
{
    //private attributes
    private string _word;
    private bool _isHidden;
    //private List<string> _listofWords;

    //word constructor
    public Word(string word)
    {
        _word = word;
        //_listofWords = word;
        _isHidden = false;
    }
    
    //display method
    public void DisplayWord()
    {
        Console.WriteLine($"The original word: {_word}"); //originlal word
        Console.WriteLine($"The word, when hidden:{LocalGetWordString()}"); //hidden word
    }

    public string LocalGetWordString()
    {
        //if the word is hidden, return underscore characters for the word.
        //one for each character in the word.
        //else return the actual word.
        if (_isHidden)
        {
            string newString = "";
            foreach(char c in _word)
            {
                newString += '_';
            }
            return newString;
        }
        else
        {
            return _word;
        }
    }

    //is hidden getter
    public bool IsHidden()
    {
        return _isHidden;
    }

    //hide word method setter. Sets bool value to true
    public void HideWord()
    {
        _isHidden = true;
    }
}