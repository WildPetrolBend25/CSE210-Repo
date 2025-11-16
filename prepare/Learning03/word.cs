using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

class Word
{
    //private attributes
    private string _word; 
    private bool _isHidden;

    //word constructor
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    //getter 
    public void HideWord()
    {
        _isHidden = true;
    }

    //setter 
    public bool IsHidden()
    {
        return _isHidden;
    }


    public string GetDisplayWord()
    {
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
  
}