using System;

class Circle
{
    public const double PI = 3.14;

    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Value of PI: " + Circle.PI);

        // Trying to modify the constant
        // Circle.PI = 3.14159;

        Circle c = new Circle();

        double radius = 5;

        Console.WriteLine("Area: " + c.CalculateArea(radius));
        Console.WriteLine("Perimeter: " + c.CalculatePerimeter(radius));
    }
}