using System;

class Program
{
    static void Main(string[] args)
    {
        //Make vscode recognize unicode chracters
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("ようこそ！日本語を入力してください！");

        // attributes 

        // instances
        CharacterManager myManager = new CharacterManager(); //Step 1 Initializes The Character Manager Class

        // menthods
        // myManager.DisplayMenu(); /*Step 2: within the chracter manager class, call the Display Menu method -> CharacterManager class */
        // myManager.DisplaySentence(); //Step 6: Call the DisplaySentence Class in the ChracterManager -> ChracterManager class   

        bool done = false;
        while (!done)
        {
            Console.Clear();
            Console.WriteLine(myManager.GetDisplayText()); //step 6: displays current state of words --> Test class GetDisplayText method

            Console.WriteLine("\nPress Enter to reveal the next word, or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                done = true;
            }
            else if (myManager.AllRevealed()) 
            //step 16: when _currentIndex exceeds word count this class will be called
            //indicating all words have been revealed and then the code will stop running
            {
                Console.WriteLine("\nAll words revealed! Well done!");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                done = true;
            }
            else
            {
                myManager.RevealNextWord();  //Step 10: reveals next word --> Test class RevealNextWord method
            }
        } 
        Console.Write("Press Enter to exit ");
        Console.ReadLine();

        //__________________________________________ Added Code ____________________________________________
        //TestNamespace.Test testInstance = new TestNamespace.Test(42); //step 1: creates instance -> Test class constructor

        // bool done = false;
        // while (!done)
        // {
        //     Console.Clear();
        //     Console.WriteLine(testInstance.GetDisplayText()); //step 6: displays current state of words --> Test class GetDisplayText method

        //     Console.WriteLine("\nPress Enter to reveal the next word, or type 'quit' to exit:");
        //     string input = Console.ReadLine().Trim().ToLower();

        //     if (input == "quit")
        //     {
        //         done = true;
        //     }
        //     else if (testInstance.AllRevealed()) 
        //     //step 16: when _currentIndex exceeds word count this class will be called
        //     //indicating all words have been revealed and then the code will stop running
        //     {
        //         Console.WriteLine("\nAll words revealed! Well done!");
        //         Console.WriteLine("Press any key to exit...");
        //         Console.ReadKey();
        //         done = true;
        //     }
        //     else
        //     {
        //         testInstance.RevealNextWord();  //Step 10: reveals next word --> Test class RevealNextWord method
        //     }
        // }

    }
}