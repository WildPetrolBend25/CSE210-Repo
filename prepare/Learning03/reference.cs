using System;
using System.IO.Compression;
class Reference
{
    //attributes 
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // constructor for if you have one verse
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = 0;

    }

    //constructuctor for if you have multiple verses 
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        // check is endverse is null type or not
        if (_endVerse == 0)
        {
            string oneVerse = $"{_book} {_chapter}: {_startVerse}";
            return oneVerse;
        }
        else
        {
            string multiVerse = $"{_book} {_chapter}: {_startVerse} - {_endVerse}";
            return multiVerse;
        }
        
    }

}