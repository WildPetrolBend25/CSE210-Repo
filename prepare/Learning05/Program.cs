using System;

class Program
{
    static void Main(string[] args)
    {
        //instances
        Shape myShape = new Shape("blue");

        Square mySquare = new Square("Green", 7.6);
        Rectangle myRectangle = new Rectangle("Black", 7.8, 4.2);
        Circle myCircle = new Circle("Blue", 2.3);

        //method calling
        //Base shape
        myShape.SetColor("Blue");
        Console.WriteLine($"The base shape's color is: {myShape.GetColor()}");

        //Square
        Console.WriteLine($"\nThe are of the {mySquare.GetColor()} square is: {mySquare.GetArea()} inches.");

        //Rectangle
        Console.WriteLine($"\nThe area of the the {myRectangle.GetColor()} rectangle is: {myRectangle.GetArea()} inches.");

        //Circle
        Console.WriteLine($"\nThe area of the {myCircle.GetColor()} circle is: {myCircle.GetArea():0.00}");
    }
}