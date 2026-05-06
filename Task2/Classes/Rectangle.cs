using Tools;

namespace Task2.Classes;

public class Rectangle
{
    private double SideA { get; }
    
    private double SideB { get; }

    public Rectangle(double a, double b)
    {
        if (a <= 0)
            throw new Exception(ErrorMessages.GetValueMustBeGreaterThanZeroError("Side A"));
        
        if (b <= 0)
            throw new Exception(ErrorMessages.GetValueMustBeGreaterThanZeroError("Side B"));
        
        SideA = a;
        SideB = b;
    }

    public double Perimeter() => (SideA + SideB) * 2;
    
    public double Square() => SideA * SideB;
}