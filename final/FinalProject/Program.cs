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
        myManager.DisplayMenu(); /*Step 2: within the chracter manager class, call the Display Menu method -> CharacterManager class */
        myManager.DisplaySentence(); //Step 6: Call the DisplaySentence Class in the ChracterManager -> ChracterManager class    
        

        Console.Write("Press Enter to exit ");
        Console.ReadLine();


    }
}