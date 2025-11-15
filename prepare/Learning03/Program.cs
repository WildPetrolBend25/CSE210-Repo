using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //set up our instances of data 
        Reference ref1 = new Reference("John", 3, 16); 
        Scripture scripture1 = new Scripture(ref1, "For God so loved the world that he sent his only begotten son");


        scripture1.GetDispalyText();
    }
}


// Notes:
// got a list passed in through a constructor (((✅)))
// make sure that all items in a list are returned as as ____, _____, _____ ((()))

