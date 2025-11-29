using System;

class Shape
{
    //attributes
    private string _color;

    //constructors
    public Shape(string color)
    {
        _color = color;
    }

    //methods
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        //area calculations
        double _area = 0.0;
        return _area;
    }

    //testing purposes 
    public void DisplayColor() //(((❌)))
    {
        Console.WriteLine(_color);
    }

}