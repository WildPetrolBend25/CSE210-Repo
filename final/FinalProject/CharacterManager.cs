using System;
using System.Reflection;
class CharacterManager
{
    //attributes
   

    // instances
    Menu mymenu = new Menu(); //Step 3: Create a new instance of menu
    private Character myCharacter; //Step 7: setup the instance of myCharacter -> ChracterManager Constructor
    private Kanji myKanji = new Kanji("null", false);

    // constructors
    public CharacterManager()
    {
        //Completion Status: (((✅)))
        //Enter a Japanese Sentence 
        Console.Write("Please enter a Japanese Sentence to review: ");
        string _japaneseSentence = Console.ReadLine();

        myCharacter = new Character(_japaneseSentence, false); /*Step 8: create new instance in constructor with 
        require elements in Chracter class constructor -> Character class*/
    }

    // methods
    public void DisplayMenu() /*Step 4: Access the DisplayMenu method with the new and call the new Menu instance
    GetMenu method + display each item in the string -> Menu class */ 
    //Completion Status (((✅)))
    {
        List<string> _menuOptions = mymenu.GetMenu();
        foreach (string item in _menuOptions)
        {
            Console.WriteLine(item);
        }
    }

    public void DisplaySentence() /*Step 10: using the myCharacter instance, call the Display sentence method, which
    is built to turn the sentence passed in, into a Array and then print the array -> DisplaySentence method*/
    //Completion status: (((🦺)))
    {
        string[] ArraySentence = myCharacter.SentenceToArray(); /*Step 11: creates a new array and calls SentenceToArray method in 
        Character class -> Character class */
        string [] kanjiArray = myKanji.GetKanjiArray();
        List<string> mylist = CheckForKanji(ArraySentence, kanjiArray); //checks for which kanji's are in the sentence and then marks them with ____

        foreach (string item in mylist)
        {
           Console.WriteLine(item); 
        }
    }

    public List<string> CheckForKanji(string[] sentenceChars, string[] kanjiList) 
    //Completion Status: (((🦺)))
    {
        //local variable
        List<string> newlist = new List<string>();

        Console.WriteLine("\nKanji found in your sentence:");


        foreach (string ch1 in sentenceChars)
        {
            bool isKanji = false;
            foreach (string ch2 in kanjiList)
            {
                if (ch1 == ch2)
                {
                    isKanji = true;
                    break;
                }
            }
            if (isKanji)
            {
                newlist.Add("__");
            }
            else
            {
                newlist.Add(ch1);
            }
        }
        return newlist;
     
    }

}