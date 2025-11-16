using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    //private attributes
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(" ");
        foreach(string word in wordArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    
    //word on you first 
    public void GetDisplayText()
    {
        Console.Write(_reference.GetReference() + " ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayWord() + " ");
        }
        Console.WriteLine(); //new line 
    }

    public void HideRandomWord()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        if (visibleWords.Count == 0)
        {
            return;
        }

        Random rand = new Random();
        int index = rand.Next(0, visibleWords.Count);
        Word wordToHide = visibleWords[index];
        wordToHide.HideWord();
    }

    public bool CompletlyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}