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
    public double GetArea()
    {
        double _area = 0.0;
        return _area;
    }

}