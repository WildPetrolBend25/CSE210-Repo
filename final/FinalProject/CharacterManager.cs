using System;
using System.Reflection;
class CharacterManager
{
    //attributes
   

    // instances
    Menu mymenu = new Menu(); //Step 3: Create a new instance of menu
    private Character myCharacter; //Step 7: setup the instance of myCharacter -> ChracterManager Constructor

    // constructors
    public CharacterManager()
    {
        myCharacter = new Character("How was your day?", false); /*Step 8: create new instance in constructor with 
        require elements in Chracter class constructor -> Character class*/
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
            Console.Write($"{item} "); //Step 13: prints the sentence from myCharacter's instance
        }
        
    }

   

}