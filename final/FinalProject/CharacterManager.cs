using System;
using System.Reflection;
class CharacterManager
{
    //attributes <<<🟦>>>
    private int _currentIndex = 0;
    private List<Character> _words = new List<Character>();
   

    // instances <<<🟦>>>
    Menu mymenu = new Menu(); //Step 3: Create a new instance of menu
    private Character myCharacter; //Step 7: setup the instance of myCharacter -> ChracterManager Constructor
    private Kanji myKanji = new Kanji("null"); 

    // constructors <<<🟦>>>
    public CharacterManager()
    {
        //Completion Status: (((✅)))
        string[] _userInput = SetSentence();
        WordsToList(_userInput); // Step 3: converts string array to Word objects -> populates _words list
        HideAllWords(); // Step 4: hides all words initially -> Hide All words in Kanji Array
        _currentIndex = 0; // Step 5: initializes current index to 0 --> Program class 
    }

    // methods <<<🟦>>>
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

    public string[] SetSentence()
    {
        //Enter a Japanese Sentence 
        Console.Write("Please enter a Japanese Sentence to review: ");
        string _japaneseSentence = Console.ReadLine();
        string[] _sentenceArray = _japaneseSentence.Select(c => c.ToString()).ToArray();
        return _sentenceArray;
    }

    public void WordsToList(string [] userInput)
        {
            foreach(string character in userInput) 
            {
                Character newWord = new Character(character); //an object in the word class has the attribute of the word and hidden state
                _words.Add(newWord); //add those word obejcts to a list of objects
            }
        }
    
    private void HideAllWords() 
        {
            // foreach (Character word in _words)
            // {
            //     word.SetHidden(true);
            // }

            string [] kanjiArray = myKanji.GetKanjiArray(); //get an array of all the kanji characters

            foreach (Character myChra in _words) //run through each character object
            {
                string stringChra = myChra.ToString(); //Place of interest (((🟨)))
                foreach (string kanjiChar in kanjiArray)
                {
                    if (stringChra == kanjiChar)
                    {
                        myChra.SetHidden(true);
                    }
                }
            }
        }

    public string GetDisplayText() //Step 7: returns current state of words as a string
        {
            string sentence = "";
            for (int i = 0; i < _words.Count; i++)
            {
                if (i > 0) sentence += " ";
                sentence += _words[i].GetDisplayWord(); 
                //step 8: gets display word (hidden or revealed) from each Word object --> Word class GetDisplayWord method
            }
            return sentence;
        }

    public void RevealNextWord() //step 11: reveals the next word in the list
        {
            if (_currentIndex < _words.Count)
            {
                _words[_currentIndex].SetHidden(false); 
                //step 12: Since all words have hidden set to true
                //this sets the current word to revealed --> Word class SetHidden method
                _currentIndex++; //Step 14: increments current index to point to next word --> Program class loop
            }
        }

    public bool AllRevealed()
        {
            return _currentIndex >= _words.Count; 
            //step 15: checks if all words have been revealed / when _currentIndex exceeds word count
            //because it it increments after revealing each word --> Program class loop
        }
    

}