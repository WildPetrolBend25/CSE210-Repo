using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    //private attributes
    private Reference _reference;
    private List<string> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
    }
    
    public void GetDisplayText()
    {
        //nothing here yet 
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