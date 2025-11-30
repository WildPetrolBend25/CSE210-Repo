class Circle : Shape
{
    //attributes
    private double _radius;

    //constructors
    public Circle(string name, string color, double radius) : base(name, color)
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