using System;

class Journal
{
    public string userJournal(string journalEntry) //pass in journal Entry
    {
        List<string> combinedJournal = new List<string>();
        combinedJournal = [];
        combinedJournal.Add(journalEntry);

        //run through the journal 
        int count = 1;
        foreach (string Entry in combinedJournal)
        {
            Console.WriteLine($"The users {count} {Entry}");
            count++;
        }
    }
}