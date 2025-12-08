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
        //Completion Status: (((🦺)))
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
        CheckForKanji(ArraySentence, kanjiArray);
    }

    public void CheckForKanji(string[] sentenceChars, string[] kanjiList) 
    //Completion Status: (((🦺)))
    {
        Console.WriteLine("\nKanji found in your sentence:");

        foreach (string ch in sentenceChars)
        {
            if (kanjiList.Contains(ch))
            {
                Console.WriteLine($"'{ch}' is a kanji!");
            }
        }
    }

}