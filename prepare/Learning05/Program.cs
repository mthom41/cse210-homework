using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle circ = new Circle((float)2.25, "green");
        Rectangle rect = new Rectangle((float)5.61, (float)8.004, "red");
        Square squ = new Square((float)1.2, "orange");
        shapes.Add(squ);
        shapes.Add(circ);
        shapes.Add(rect);
        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine($"Color: {shape.GetColor()}");
        }

    }
}