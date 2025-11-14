using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //new instances
        Word myWord = new Word("uncle");

        // try passing in a list of words to a different constructor
        List<string> myList = new List<string>();
        myList = ["Hello", "how","are","you"];
        Word myListWord = new Word(myList);
        myListWord.DisplayList();

        //Call methods
        myWord.HideWord(); //sets the bool value from false to true
        if (myWord.IsHidden())
        {
            //if bool is true, then the word is hidden
            Console.WriteLine("The Word is hidden");
        }
        else
        {
            //if bool value is false
            Console.WriteLine("Is not hidden... yet");
        }
        //displays the word after hiding or not hiding it
        myWord.DisplayWord();



    }
}


// Notes:
// make sure that all items in a list are returned as as ____, _____, _____

