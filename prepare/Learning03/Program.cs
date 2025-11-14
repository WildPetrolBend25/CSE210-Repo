using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //new instances
        Word myWord = new Word("uncle");
        //List<string> ListofWords = ["Hi", "how","are","you"];
        // List<string> TrySomeWords = ["Hi", "how","are","you"];
        // Scripture NewList = new Scripture(TrySomeWords);
        // List<string> obtainedlist= NewList.GetScriptureList();
        //Word newWord2 = new Word(obtainedlist);

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

