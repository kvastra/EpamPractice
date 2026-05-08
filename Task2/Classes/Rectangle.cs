using Tools;

namespace Task2.Classes;

public class Rectangle: IFigure
{
    private double SideA { get; }
    
    private double SideB { get; }
    
    public FigureType Type { get; init; }

    public Rectangle(double a, double b)
    {
        if (a <= 0)
            throw new Exception(ErrorMessages.GetValueMustBeGreaterThanZeroError("Side A"));
        
        if (b <= 0)
            throw new Exception(ErrorMessages.GetValueMustBeGreaterThanZeroError("Side B"));
        
        SideA = a;
        SideB = b;
        Type = FigureType.Rectangle;
    }
    
    public Rectangle(double[] args): this(args[0], args[1]){}

    public double Perimeter => (SideA + SideB) * 2;
    
    public double Square => SideA * SideB;

    public override string ToString() => $"Rectangle: " +
                                         $"a = {SideA}, b = {SideB}, " +
                                         $"Perimeter = {Perimeter}, " +
                                         $"Square = {Square}";
}