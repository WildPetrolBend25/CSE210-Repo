
class Circle
{
    private double _radius;

    //default constructor
    public Circle()
    {

    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Invalid radius, must >= 0.0");
            _radius = 0;
        }
        else
        {
            _radius = radius;
            
        }
    }

    public double GetCircleArea()
    {
        return 3.1415 * _radius * _radius;
    }

    public double GetCircumference()
    {
        return _radius * 2 * Math.PI;
    }
    
    
}