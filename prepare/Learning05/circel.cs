class Circle : Shape
{
    //attributes
    private double _radius;

    //constructors
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //metods
    public override double GetArea()
    {
        double _area = Math.PI * (_radius * _radius);
        return _area;
    }
}