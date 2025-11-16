using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        //set up our instances of data 
        Reference ref1 = new Reference("John", 3, 16); 
        Scripture scripture1 = new Scripture(ref1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        
        bool done = false;
        while (!done)
        {
            Console.Clear();
            scripture1.GetDisplayText();

            Console.WriteLine("\nPress Enter to hida a word, or type 'quit':");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                done = true;
            }
            
            if (scripture1.CompletlyHidden())
            {
                Console.WriteLine("All the words have been hidden");
                done = true;
            }
            for (int i = 0; i < 3; i++)
            {
                scripture1.HideRandomWord();
            }
        } 
    }
}


