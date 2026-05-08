using Tools;

namespace Task2.Classes;

public class Round : IFigure
{
    private double CenterX { get; set; }
    
    private double CenterY { get; set; }
    
    private double Radius { get; set; }
    
    public FigureType Type { get; init; }

    public Round(double x, double y, double radius)
    {
        if (radius <= 0)
            throw new Exception(ErrorMessages.GetValueMustBePositiveError("Radius"));

        CenterX = x;
        CenterY = y;
        Radius = radius;
        Type = FigureType.Round;
    }

    public Round(double[] args) : this(args[0], args[1], args[2]) {}
    
    public double Perimeter => 2 * Math.PI * Radius;
    
    public double Square => Math.PI * Radius * Radius;

    public override string ToString() => $"Round: " +
                                         $"Center = ({CenterX}, {CenterY}), " +
                                         $"Perimeter = {Perimeter}, " +
                                         $"Square = {Square}";
}