namespace pl1;

public class Rectangle: Figure
{
    public double Length { get; }
    public double Width { get; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public override double CalculateArea()
    {
        return Length * Width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}