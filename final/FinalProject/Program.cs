using System;

class Program
{
    static void Main(string[] args)
    {
        //Make vscode recognize unicode chracters
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;


        // attributes <<<🟦>>>

        // instances <<<🟦>>>
        Menu mymenu = new Menu(); //Step []: Create a new instance of menu 

        // menthods <<<🟦>>>
        mymenu.DisplayMenu();
        int userInput = mymenu.ObtainUserInput();

        //go through the loop
        bool done = false;
        while (!done)
        {
            if (userInput == 1)
            {
                Console.WriteLine("ようこそ！日本語を入力してください！");
                CharacterManager myManager = new CharacterManager(); //Step [] Initializes The Character Manager Class
                bool done2 = false;
                while (!done2)
                {
                    Console.Clear();
                    Console.WriteLine(myManager.GetDisplayText()); //step 6: displays current state of words --> Test class GetDisplayText method

                    Console.WriteLine("\nPress Enter to reveal the next word:");
                    string input = Console.ReadLine().Trim().ToLower();


                    if (myManager.AllRevealed()) 
                    //step 16: when _currentIndex exceeds word count this class will be called
                    //indicating all words have been revealed and then the code will stop running
                    {
                        Console.WriteLine("\nAll words revealed! Well done!");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        done2 = true;
                        done = true;
                    }
                    else
                    {
                        myManager.RevealNextWord();  //Step 10: reveals next word --> Test class RevealNextWord method
                    }
                }
                
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Nothing here yet #2");
                done = true;
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Nothing Here yet #3");
                done = true;
            }
            else
            {
                done = true;
            }
            
        } 
    }
}