using System;
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
        string scriptureRef = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        return scriptureRef;
    }

    public string DisplayReference()
    {
        string _reference = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        return _reference;
    }
}