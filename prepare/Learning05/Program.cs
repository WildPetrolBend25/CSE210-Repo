using System;

class Program
{
    static void Main(string[] args)
    {
        //instances
        Shape myShape = new Shape("blue");

        //nethod calling
        myShape.SetColor("Blue");
        string obtainedColor = myShape.GetColor();
        Console.WriteLine($"The color is: {obtainedColor}");
    }
}