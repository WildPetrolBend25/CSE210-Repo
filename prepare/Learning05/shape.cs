using System;

class Shape
{
    //attributes
    private string _color;
    private string _name;

    //constructors
    public Shape(string name, string color)
    {
        _name = name;
        _color = color;
    }

    //methods
    public string GetColor()
    {
        return _color;
    }

    public string GetName()
    {
        return _name;
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

}