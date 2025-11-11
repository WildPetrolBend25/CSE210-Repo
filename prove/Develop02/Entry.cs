using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Entry
{
    public string CreateEntry()
    {
        //set up the list of prompts 
        List<string> entryPrompts = new List<string>();
        entryPrompts =
        ["Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What's something you wish you had done today",
        "What's the thing you are most proud of today?",
        "How did I see the hand of the Lord in my life today?"];

        // pick random number based on index
        int x = 1;
        int y = 6;
        Random randomGeneratior = new Random();
        int randNumber = randomGeneratior.Next(x, y);
        string randomPrompt = entryPrompts[randNumber];

        //get user response
        Console.WriteLine($"{randomPrompt}");
        Console.Write("> ");
        string userResponse = Console.ReadLine();

        //get the date time
        DateTime now = DateTime.Now;
        string textVersion = now.ToString();

        //make the full journal entry
        string journalEntry = $"Date: {textVersion}, Prompt: {randomPrompt}, User entry: {userResponse}";

        //return the journal entry
        return journalEntry;
    }
    
    
}