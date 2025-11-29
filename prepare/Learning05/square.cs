using System;

class Square : Shape
{
    //attributes
    private double _side;

    //constructors
    public Square(string color, double side) : base(color)
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