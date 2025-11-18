using System;

class Assignments
{
    //attributes
    private string _studentName;
    private string _topic;

    //constructor
    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //methods
    public string GetSummary()
    {
        return $"Name:{_studentName}, Topic:{_topic} ";
    }
}