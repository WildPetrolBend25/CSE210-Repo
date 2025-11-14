using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //new instance of word
        Word myWord = new Word("Uncle");
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

