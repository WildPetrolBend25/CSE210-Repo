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
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
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
        string username = "Hello";
        Console.WriteLine(username);
    }
    // public void doesThisWork()
    // {
    //     Console.WriteLine("not problems here");
    // }

}