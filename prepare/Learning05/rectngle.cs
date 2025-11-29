class Rectangle : Shape
{
    //attributes
    private double _length;
    private double _width;

    //constructors
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //metods
    public double GetArea()
    {
        double _area = 0.0;
        return _area;
    }
}