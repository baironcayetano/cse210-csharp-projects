using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(7,5);
        rectangle.SetColor("Blue");

        Circle circle = new Circle(4);
        circle.SetColor("Green");
        
        Square square = new Square(5);
        square.SetColor("Red");

        List<Shape> shapes = new List<Shape>{rectangle, circle, square};
        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"The area of the shape is {shape.GetArea()} and its color is {shape.GetColor()}");
        }
   
    }
}