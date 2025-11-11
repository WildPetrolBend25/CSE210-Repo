using System;

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
        //run through the journal 
        int count = 1;
        foreach (string Entry in combinedJournal)
        {
            Console.WriteLine($"Entry#: {count}, User Entry:{Entry}");
            count++;
        }
    }

    //write all items in the journal to a file
    public void writeToFile() //add the journalEntry parameter
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
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