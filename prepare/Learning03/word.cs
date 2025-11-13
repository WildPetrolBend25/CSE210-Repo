using System.ComponentModel.DataAnnotations;

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
    
    //display method
    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }
}