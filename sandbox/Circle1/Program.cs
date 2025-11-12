class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        Circle _myCircle = new Circle();

        //_myCircle._radius = 10;
        //how to access otherwise private data 
        _myCircle.SetRadius(10);

        Console.WriteLine(_myCircle.GetCircleArea());
    
    }
}
