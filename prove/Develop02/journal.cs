using System;
using System.IO;

class Journal
{
    //add the journal entry to the list
    private List<string> combinedJournal = new List<string>();

    // Add the journal entry to the existing list
    public List<string> addToJournal(string journalEntry)
    {
        combinedJournal.Add(journalEntry);
        return combinedJournal;
    }

    //go through all items in the journal
    public void journalDisplay(List<string> combinedJournal)
    {
        //Welcome the the journal
        Console.WriteLine("Here is your combinded journal");
        //run through the journal 
        int count = 1;
        foreach (string Entry in combinedJournal)
        {
            Console.WriteLine($"Entry#: {count}, {Entry}");
            count++;
        }
    }

    //write all items in the journal to a file
    public void writeToFile(List<string> fullJournal) //add the journalEntry parameter
    {
        //file name
        string filename = "myFile.txt";

        //output file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //go through each element and then write it to the output file
            foreach (string journalEntry in fullJournal)
            {
                outputFile.WriteLine(journalEntry);
            }
            Console.WriteLine("Your journal Entry('s) have been saved");

        }
    }
    
    //read all entries from a file
    public void readFromFile()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        //welcome to the file
        Console.WriteLine($"Here are all your previous entries in {filename}");

        //go through each item in the file
        foreach (string line in lines)
        {
            //print each journal entry
            Console.WriteLine(line);
        }
            
    }
}