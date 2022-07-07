namespace pl1;

public class Circle: Figure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Radius * Math.Pow(3.14, 2);
    }

    public override double CalculatePerimeter()
    {
        return Radius * 6.28;
    }
}