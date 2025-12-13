using System;
using System.IO;
class Kanji : Character
{
    // attributes <<<🟦>>>
    private string[] KanjiArray; //set up list to contain kanji's
    
    // constructors <<<🟦>>>
    public Kanji(string sentence) : base(sentence)
    {
        //Completion Status: (((✅)))
        // This finds your project folder automatically when running from bin/Debug/net8.0
        string projectDirectory = Directory.GetParent(AppContext.BaseDirectory)!.Parent!.Parent!.Parent!.FullName;
        string filename = Path.Combine(projectDirectory, "kanji_string.txt");
        string allKanjis = File.ReadAllText(filename).Trim(); //Reads whole file as one string
        KanjiArray = allKanjis.Select(c => c.ToString()).ToArray(); //splits the string of kanji's into just onle line characters
    }

    
    //Methods <<<🟦>>>
    public string[] GetKanjiArray()
    {
        return KanjiArray;
    }

}