using System;

class WritingAssignment : Assignments
{
    //attributes
    private string _title;

    //constructors
    public WritingAssignment(string name, string topic, string title) :base(name, topic)
    {
        _title = title;
    }

    //methods
    public string GetWritingInformation()
    {
        return $"Title:{_title}";
    }
}