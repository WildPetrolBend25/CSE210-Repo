using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    //private attributes
    private string _scrReference;
    private string _words;

    public Scripture(Reference reference, string words)
    {
        _scrReference = $"{reference}, {words}";
    }
    
    public void GetDispalyText()
    {
        Console.WriteLine(_scrReference);
    }

    public void HideRandomWord()
    {
        //nothing here yet 
    }

    public void CompletlyHidden()
    {
        // checks to see if all word are hidden or not
    }
}