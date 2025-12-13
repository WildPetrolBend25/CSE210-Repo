using System;
using System.Reflection;
class CharacterManager
{
    //attributes <<<🟦>>>
    private int _currentIndex = 0; //(❌)
    private List<int> _indexOFHiddenChars = new List<int>();
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
        HideSameChars(); // Step 4: hides all words initially -> Hide All words in Kanji Array
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

    public string[] SetSentence() //(((✅)))
    {
        //Enter a Japanese Sentence 
        Console.WriteLine("Copy and paste this sentence for testing purposes: 今日はいい天気ですね");
        Console.Write("Please enter a Japanese Sentence to review: ");
        string _japaneseSentence = Console.ReadLine();
        string[] _sentenceArray = _japaneseSentence.Select(c => c.ToString()).ToArray();
        return _sentenceArray;
    }

    public void WordsToList(string [] userInput) //(((✅)))
        {
            foreach(string character in userInput) 
            {
                Character newWord = new Character(character); //an object in the word class has the attribute of the word and hidden state
                _words.Add(newWord); //add those word obejcts to a list of objects
            }
        }
    
    private void HideSameChars() //(((✅))) //(((🟨 made a change with Hideallwords method)))
        {
            string [] kanjiArray = myKanji.GetKanjiArray(); //get an array of all the kanji characters

            foreach (Character myChra in _words) //run through each character object
            {
                string stringChra = myChra.ToString(); //ovveride ToString() in chracter class bc toString only returns the name if chracterclass
                foreach (string kanjiChar in kanjiArray)
                {
                    if (stringChra == kanjiChar)
                    {
                        myChra.SetHidden(true);

                        //Find the index of the object that was hidden
                        int index = _words.IndexOf(myChra);
                        _indexOFHiddenChars.Add(index);
                        
                    }
                }
            }
        }

    public string GetDisplayText() //Step 7: returns current state of words as a string (((🟨))): Change incrementation to only jump to words hidden
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

    public void RevealNextWord() //step 11: reveals the next word in the list (((✅)))
        {
            // if (_currentIndex < _words.Count)
            // {
            //     _words[_currentIndex].SetHidden(false); 
            //     //step 12: Since all words have hidden set to true
            //     //this sets the current word to revealed --> Word class SetHidden method
            //     _currentIndex++; //Step 14: increments current index to point to next word --> Program class loop
            // }

            if (_currentIndex < _indexOFHiddenChars.Count()) 
            //currentIndex runs through the list of indexes where the characters are hidden
            //current index should be incremented by ++
            {
                int _hiddenCharIndex = _indexOFHiddenChars[_currentIndex];
                _words[_hiddenCharIndex].SetHidden(false); //Reveals only the hidden character
                _currentIndex++;
            }

        }

    public bool AllRevealed() //(((✅)))
        {
            //return _currentIndex >= _words.Count; 

            return _currentIndex >= _indexOFHiddenChars.Count();
            
            //step 15: checks if all words have been revealed / when _currentIndex exceeds word count
            //because it it increments after revealing each word --> Program class loop
        }

    public void DisplayIndex() //(((Test program ❌))) 
    {
        foreach (int item in _indexOFHiddenChars)
        {
            Console.WriteLine(item);
        }
    }
}