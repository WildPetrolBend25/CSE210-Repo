using System;

class Square : Shape
{
    //attributes
    private double _side;

    //constructors
    public Square(string name, string color, double side) : base(name, color)
    {
        _side = side;
    }

    //methods
    public override double GetArea()
    {
        double _area = _side * _side;
        return _area;
    }

}