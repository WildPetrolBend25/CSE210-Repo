using System;

class Listing : Activity
{

    // attributes
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public Listing(string name, string description) :base (name, description)
    {
        
    }

    public void RunActivityLogicL()
    {
        Random rand = new Random();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = _prompts[rand.Next(_prompts.Length)];

        // prompt
        Console.WriteLine($"{prompt}");
        Console.Write("You may begin in: ");
        RunCountDown(5);

        // get duration
        List<string> items = new List<string>();
        int _duration = ObtainDurration();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine();

        // adding responses to lists
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }
        // total amount of items
        Console.WriteLine($"You listed {items.Count} items!");
    }
}