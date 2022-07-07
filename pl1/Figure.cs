namespace pl1;

public abstract class Figure
{
    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();

    public override string ToString()
    {
        return $" Perimeter {CalculatePerimeter()}  Area: {CalculateArea()}";
    }
}