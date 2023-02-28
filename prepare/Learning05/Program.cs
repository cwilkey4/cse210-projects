using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(3, "Red");
        shapes.Add(square);

        Circle circle = new Circle(4, "Yellow");
        shapes.Add(circle);

        Rectangle rectangle = new Rectangle("Green", 9, 7);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"This shape is {color} and has an area of {area}.");
        }
    }
}