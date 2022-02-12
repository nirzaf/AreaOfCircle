// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Circle
{
    private const double pie = 3.14;

    public double GetArea(double radius)
    {
        return radius * radius * pie;
    }

    public double GetCircumference(double radius)
    {
        return 2 * pie * radius;
    }
}