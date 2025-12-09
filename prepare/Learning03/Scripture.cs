using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    //private attributes
    private Reference _reference;
    private List<Word> _words; //the list of word objects from step 7

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); //Step 4: initialize _words as a new list

        string[] wordArray = text.Split(" "); //Step 5: take the text passed in and turn into an array
        foreach(string word in wordArray) //Step 6: for each item in the array, pass into _words
        {
            Word newWord = new Word(word); //Step 7: creates each item in the array into a new object of word, and passes in those objects -> GetDisplayText
            _words.Add(newWord);
        }
    }
    
    //word on you first 
    public void GetDisplayText()
    {
        Console.Write(_reference.GetReference() + " "); //Step 2: Prints the reference from GetReference -> reference 
        foreach (Word word in _words) //Step 4: Calls the word object that was created in the scripture constructor -> scripture constructor
        {
            Console.Write(word.GetDisplayWord() + " ");  //Step 8: Call the GetDisplayWord method in word class for each word obejct -> word class
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