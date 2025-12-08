using System;
using System.IO;
class Kanji : Character
{
    // attributes
    private string[] KanjiArray; //set up list to contain kanji's
    
    // constructors
    public Kanji(string sentence, bool status) : base(sentence, status)
    {
        // This finds your project folder automatically when running from bin/Debug/net8.0
        string projectDirectory = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
        string filename = Path.Combine(projectDirectory, "kanji_string.txt");
        string[] lines = System.IO.File.ReadAllLines(filename);
        KanjiArray = lines; //make attribute gloabal
    }

    // Methods 
    public override string GetSentence()
    {
        return base.GetSentence();
    }

   public void DisplayKanjiList()
    {
        foreach (char kanji in KanjiArray[0]) // since it's one long string on first line
        {
            Console.Write(kanji);
        }
        Console.WriteLine();
    }
}