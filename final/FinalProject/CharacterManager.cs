using System;
using System.Reflection;
class CharacterManager
{
    //attributes
   

    // instances
    Menu mymenu = new Menu(); //Step 3: Create a new instance of menu
    private Character myCharacter; //Step 7: setup the instance of myCharacter -> ChracterManager Constructor
    private Kanji myKanji;

    // constructors
    public CharacterManager()
    {
        //Enter a Japanese Sentence 
        Console.Write("Please enter a Japanese Sentence to review: ");
        string _japaneseSentence = Console.ReadLine();

        myCharacter = new Character(_japaneseSentence, false); /*Step 8: create new instance in constructor with 
        require elements in Chracter class constructor -> Character class*/

        myKanji = new Kanji("ありがとうございました", false);
        myKanji.DisplayKanjiList(); //(((🦺)))
    }

    // methods
    public void DisplayMenu() /*Step 4: Access the DisplayMenu method with the new and call the new Menu instance
    GetMenu method + display each item in the string -> Menu class */
    {
        List<string> _menuOptions = mymenu.GetMenu();
        foreach (string item in _menuOptions)
        {
            Console.WriteLine(item);
        }
    }

    public void DisplaySentence() /*Step 10: using the myCharacter instance, call the Display sentence method, which
    is built to turn the sentence passed in, into a Array and then print the array -> DisplaySentence method*/
    {
        string[] ArraySentence = myCharacter.SentenceToArray(); /*Step 11: creates a new array and calls SentenceToArray method in 
        Character class -> Character class */
        foreach (string item in ArraySentence)
        {
            if (item == "雨")
            {
                Console.WriteLine("Awesome, it regonized it");
                Console.Write($"{item} "); //Step 13: prints the sentence from myCharacter's instance
                Console.WriteLine(); //reset the cursor
            }
            else
            {
                Console.WriteLine(item);
            }
            
        }  
    }
    



    // public void CheckForKanji() (((use later 🦺)))
    // {
    //     bool found = false;
    //     foreach (int num1 in list1)
    //     {
    //         foreach (int num2 in list2)
    //         {
    //             if (num1 == num2)
    //             {
    //                 found = true;
    //                 break; // exit inner loop early
    //             }
    //         }
    //         if (found) break; // exit outer loop early
    //     }

    //     if (found)
    //     {
    //         Console.WriteLine("Congrats, it's in the list");
    //     }
    //     else
    //     {
    //         Console.WriteLine("No common numbers");
    //     }

    // }

   

}