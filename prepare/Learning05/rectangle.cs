class Rectangle : Shape
{
    //attributes
    private double _length;
    private double _width;

    //constructors
    public Rectangle(string name, string color, double length, double width) : base(name, color)
    {
        _length = length;
        _width = width;
    }

    //metods
    public override double GetArea()
    {
        double _area = _length * _width;
        return _area;
    }
}