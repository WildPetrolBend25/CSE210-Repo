using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List<string> words;
        // make a list, declare its data type and then set aside place in memory for list
        List<int> numbers;
        numbers = new List<int>();

        List<string> words = new List<string>();
        words.Add("Hello");
        words.Add("you");
        words.Add("are");
        words.Add("gay");

        foreach (string i in words)
        {
            Console.WriteLine(i);
        }
    }
}