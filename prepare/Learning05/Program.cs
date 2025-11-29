using System;

class Program
{
    static void Main(string[] args)
    {
        //instances
        Shape myShape = new Shape("blue");
        Square mySquare = new Square("Green", 7.6);

        //method calling
        //Base shape
        myShape.SetColor("Blue");
        Console.WriteLine($"The base shape's color is: {myShape.GetColor()}");

        //Square
        Console.WriteLine($"\nThe {mySquare.GetColor()} square has an area of: {mySquare.GetArea()} inches.");
    }
}