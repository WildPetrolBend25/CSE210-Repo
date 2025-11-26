using System;

class Shape
{
    //attributes
    private string _color;

    //constructors
    public Shape()
    {

    }

    //methods
    public string GetShape()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public void GetArea()
    {
        //area calculations
    }

    //testing purposes 
    public void DisplayColor()
    {
        Console.WriteLine(_color);
    }

}