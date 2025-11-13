using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //new instance of word
        Word myWord = new Word("Uncle");
        myWord.DisplayWord();
        myWord.HideWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine("The Word is hidden");
        }

        //Console.WriteLine(myWord.GetWordString()); ???
        myWord.DisplayWord();


    }
}

