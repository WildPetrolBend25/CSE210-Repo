using System;
using System.Runtime.CompilerServices;
class MathAssignment : Assignments
{
    //attributes
    private string _textbookSection;
    private string _problems;

    //constrctors 
    public MathAssignment(string name, string topic, string section, string problem) :base(name, topic)
    {
        _textbookSection = section;
        _problems = problem;
    }

    //methods
    public string GetHomeworkList()
    {
        return $"Section:{_textbookSection}, Problems:{_problems}";
    }
}