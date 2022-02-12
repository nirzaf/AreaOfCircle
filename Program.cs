using static System.Console;


WriteLine("Enter the Radius of the circle : ");

try
{
    double rad = Convert.ToDouble(ReadLine());
    Circle c1 = new();
    WriteLine("Area of the circle is : " + c1.GetArea(rad));
    WriteLine("Circumference of the circle is: " + c1.GetCircumference(rad));

}
catch (Exception e)
{
    WriteLine(e);
    throw;
}
finally
{
    ReadKey();
}



public class Circle
{
    private const double pie = 3.14285714286;

    public double GetArea(double radius)
    {
        return radius * radius * pie;
    }

    public double GetCircumference(double radius)
    {
        return 2 * pie * radius;
    }
}